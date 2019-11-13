# Rectangle-Finder
##### (I)nterview (Q)uestions (S)eries
Question:
You have a **M x N** matrix and you should count all available rectangles in this matrix.
a rectangle has 4 point and you just can draw lines in vertical and horizontal way.

Example:
We have here a 1x3 matrix.

|1|2|3|
|---|---|---|

And we can count 6 rectangles in this matrix 
**([1], [2], [3], [1+2], [2+3], [1+2+3])**

or in a 2x3 matrix we have 18 rectangles.
**([1], [2], [3], [4], [5], [6], [1+2], [2+3], [4+5], [5+6], [1+4], [2+5], [3+6], [1+2+3], [4+5+6], [1+2+4+5], [2+3+5+6], [1+2+3+4+5+6])**

|1|2|3|
|---|---|---|
| 4 | 5 | 6 |

> Your input is an int[,] and your output should be an integer.
```csharp
int[,] input = { { 1 } };
```
```csharp
int output = 1;
```
Some examples:
```csharp
int[,] input = { { 1 } };
int output = CounterFunction(input);
// output = 1
```
```csharp
int[,] input = { { 1, 2 } };
int output = CounterFunction(input);
// output = 3
```
```csharp
int[,] input = { { 1, 2 }, { 2, 4 } };
int output = CounterFunction(input);
// output = 9
```
