'Imports System.Runtime.
Public Class OrderedJobs
    Implements IOrderedJobs
    Dim dict As New Dictionary(Of Char, List(Of String))
    Dim listOfDependencies As String = ""

    'Dim _showErrorAsDialog As Boolean


    'Sub New(Optional showErrorAsDialog As Boolean = False)
    '    _showErrorAsDialog = showErrorAsDialog
    'End Sub
    'Dim counterOfChars As Integer = 0
    ' Public Sub SetNumberOfJobs(numberOfJobs As Integer)
    ' jobs = String[numberOfJobs];
    ' End Sub

    Public Sub Register(independentJob As String, dependentJob As String) Implements IOrderedJobs.Register
        If Not (dependentJob.Length = 1 And independentJob.Length = 1) Then
            Throw New Exception("a char is expected")
        End If

        If dependentJob = independentJob Then
            Throw New Exception("Jobs can't depend on themselves")
        Else
            Register(independentJob)
            Register(dependentJob)


            Dim value As List(Of String) = dict(independentJob)
            If Not value.Contains(dependentJob) Then
                value.Add(dependentJob)
            End If
        End If


    End Sub
    Public Sub Register(job As String) Implements IOrderedJobs.Register
        If Not (job.Length = 1) Then
            Throw New Exception("a char is expected")
        End If

        If Not dict.ContainsKey(job) Then
            dict.Add(job, New List(Of String)())
        End If
    End Sub
    Public Function Sort() As String Implements IOrderedJobs.Sort
        Dim jobs As String = ""

        For Each key In dict.Keys
            jobs += key
        Next

        For Each key In dict.Keys
            If checkForCycle(key, New List(Of String)) Then
                Throw New Exception("Jobs can't have circular dependencies.")
            End If
        Next


        Dim areJobsSorted As Integer = 1
        Dim zyklus As New List(Of String)
        Dim anzahlGleicheUmtauschungen = 0
        While areJobsSorted > 0
            For Each key As String In dict.Keys
                Dim value As List(Of String) = dict(key)
                For Each job As String In value

                    If jobs.IndexOf(job) > jobs.IndexOf(key) Then '?

                        Dim a As String = key
                        Dim b As String = job
                        jobs = jobs.Replace(job, "*")
                        jobs = jobs.Replace(key, b)
                        jobs = jobs.Replace("*", a)
                        'If Not zyklus.Contains(key + job) Then

                        '    zyklus.Add(key + job)
                        'ElseIf anzahlGleicheUmtauschungen < 1 Then
                        '    anzahlGleicheUmtauschungen += 1
                        'Else : Throw New Exception("Jobs can't have circular dependencies.")
                        'End If
                    End If
                Next
            Next
            areJobsSorted = 0
            For Each key As String In dict.Keys
                Dim value As List(Of String) = dict(key)
                For Each job As String In value
                    If jobs.IndexOf(job) > jobs.IndexOf(key) Then
                        areJobsSorted += 1
                    End If
                Next
            Next
        End While
        'If anzahlGleicheUmtauschungen >= 100 Then
        '    'Throw New Exception("Jobs can't have circular dependencies.")
        '    Return "Fehler"
        'End If

        Return jobs

    End Function

    ' ''' <summary>
    ' ''' recursive check if job runs into circular dependency
    ' ''' </summary>
    'Function checkForCycle(job As String) As String
    '    Dim dependsOnJobs As List(Of String) = dict(job)

    '    For Each dependentJob As String In dependsOnJobs
    '        listOfDependencies = job + checkForCycle(dependentJob)
    '    Next
    '    Return listOfDependencies

    'End Function

    'Function checkForSimilarJobs(listOfDependencies As String) As Boolean
    '    For Each job1 In listOfDependencies
    '        Dim k As Integer = listOfDependencies.IndexOf(job1)
    '        If Not listOfDependencies.Substring(k).Contains(job1) Then
    '            Return False
    '        End If
    '    Next

    '    Return True
    'End Function


    ''' <summary>
    ''' recursive check if job runs into circular dependency
    ''' </summary>
    Function checkForCycle(job As String, visitedJobs As List(Of String)) As Boolean
        If visitedJobs.Contains(job) Then
            Return True
        End If

        Dim newVisitedJobs As New List(Of String)(visitedJobs)
        newVisitedJobs.Add(job)

        Dim dependsOnJobs As List(Of String) = dict(job)

        For Each dependentJob As String In dependsOnJobs
            If checkForCycle(dependentJob, newVisitedJobs) Then
                Return True
            End If
        Next

        Return False
    End Function
End Class
