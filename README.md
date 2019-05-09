# Simple Testcases Generator
It's convert the pseudo code to C# code and run some test cases on this code.

Test Cases generated but not tested well.

Not Supported (Keywords):
- Print
- For
- Do While

Not Supported:
- Nested Conditions
- Nested Loops

## You can test this samples
###### First
```
READ num1, num2, result
IF num1 > num2
result = num1
ELSE
result = num2
ENDIF
RETURN result
```

###### Second
```
READ num1, res, i
num1 = 1
i = 1
WHILE i <= 20
res = num1 * i
i++
ENDWHILE
RETURN res
```
