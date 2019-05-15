# Simple Test Cases Generator
It's convert the pseudo code to C# code and run some test cases on this code.

- [x] Convert Pseudo Code to C# Code.
- [x] Generate Test Cases.
- [x] Foramt Output Results.

### Not Supported:
- Nested Conditions
- Nested Loops
- Keywords
  - Print
  - For
  - Do While

## You Can Test This Samples
###### 1.1
```
READ x, y, z
z = x/y
RETURN z
```
###### 1.2
```
READ x, y, z
IF (y != 0)
z = x/y
ENDIF
RETURN z
```

###### 2
```
READ num1, num2, result
IF num1 > num2
result = num1
ELSE
result = num2
ENDIF
RETURN result
```

###### 3
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
