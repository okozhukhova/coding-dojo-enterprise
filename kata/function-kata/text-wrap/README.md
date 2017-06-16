# Text Wrap
Write a function that wraps a string to a maximum line length in characters. 

* Try to approach this in a TDD (Test Driven Development) manner 
    * For each part functionality you implement write a test first (of course it will fail at first)
* Wrapping should be word-wise (only whole words should be wrapped)
    * Words are surrounded by 'whitespace'
* If one word is longer than the given line length it will be wrapped letterwise

**Input**
> Text and MaxLineLength
```java
text-wrap "text" 3
text-wrap "Is this the real live" 13
```

**Output**
> Wrapped text. Linebreaks are added to the string

```java
"tex\nt"
"Is this the \nreal live"
``` 