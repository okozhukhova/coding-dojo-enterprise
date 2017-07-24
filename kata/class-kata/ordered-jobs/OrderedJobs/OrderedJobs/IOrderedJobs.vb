Public Interface IOrderedJobs
  



    ' // registers a job with a dependency to 'independentJob'
    Sub Register(dependentJob As String, independentJob As String)
    ' // registers a job without dependency
    Sub Register(job As String)
    Function Sort() As String

End Interface

