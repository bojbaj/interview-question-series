# Deletion Distance
##### (I)nterview (Q)uestions (S)eries
Question:
The deletion distance between two string is the minimum number of characters you need to delete in the two strings in order to get the same string.
For instance, the deletion distance between **"heat"** and **"hit"** is **3**:
- by deleting "e" and "a" in "heat", and "i" in "hit" we get the string "ht" in both cases.
- we can't get the same string from both sides by deleting two or less leters.

Example:
input: str1 = "dog", str2 =  "frog"
output: 3

input: str1 = "some", str2 =  "some"
output: 0

input: str1 = "some", str2 =  "thing"
output: 9

input: str1 = "", str2 =  ""
output: 0

> Your inputs are two **string** variable and your output should be an **int**.
```csharp
string input1 = "dog";
string input2 = "frog";
```
```csharp
int output = 3;
```
Some examples:
```csharp
string input1 = "dog";
string input2 = "frog";
int output = DeletionDistanceCalculator(input1, input2);
// output = 3
```
