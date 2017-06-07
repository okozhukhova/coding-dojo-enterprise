# Ordered Jobs
A class has to be implemented that can be used to create a plan for the work on multiple jobs. The jobs may have dependencies between each other. 

* Try to approach this in a TDD (Test Driven Development) manner 
    * For each part functionality you implement write a tests first (of course they will fail at first)

## Definition
The ordered jobs only defined by their name (string). The interface that should be used by the new class should look like this:
```java
interface IOrderedJobs {
  // registers a job with a dependency to 'independentJob'
  void Register(char dependentJob, char independentJob);
  // registers a job without dependency
  void Register(char job);
 
  string Sort();
}
```
 
* A job can be registered multiple times (with different dependencies) but it should only show up once in the output joblist
* Cyclic dependencies should create an error

## Input
>The jobs that should be registered will be added using Register()
```java
Register('c');
Register('b', 'a');
Register('c', 'b');
```

## Output
>The sort() function should return the sorted jobs as a string
```java
"abc"
```

[ccd-school](http://ccd-school.de/coding-dojo/class-katas/ordered-jobs/)