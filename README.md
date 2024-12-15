# Stack Overflow Bug in C# Recursive Method

This repository demonstrates a common error in recursive functions: stack overflow. The `MyMethod` function recursively calls itself until the stack overflows. This occurs when the input values do not lead to a base case (a == 0 or b == 0) in a reasonable number of steps. The solution demonstrates how to fix it using an iterative approach.