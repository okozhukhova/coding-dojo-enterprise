# Csv Table
A function for a nice visualization of a csv file is needed!

**Input:**
> The file content as a String 

```java
csv-table "Name;Strasse;Ort;Alter\n
            Peter Pan;Am Hang 5;12345 Einsam;42\n
            Maria Schmitz;Kölner Straße 45;50123 Köln;43\n
            Paul Meier;Münchener Weg 1;87654 München;65"
```

**Output:**
> The nicely printed csv-table to terminal:

```java
 |Name         |Strasse         |Ort          |Alter|
 |-------------+----------------+-------------+-----+
 |Peter Pan    |Am Hang 5       |12345 Einsam |42   |
 |Maria Schmitz|Kölner Straße 45|50123 Köln   |43   |
 |Paul Meier   |Münchener Weg 1 |87654 München|65   |
```

Source:
[ccd-school](http://ccd-school.de/coding-dojo/function-katas/csv-tabellieren/)