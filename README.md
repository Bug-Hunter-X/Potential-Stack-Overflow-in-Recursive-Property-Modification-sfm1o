# Potential Stack Overflow in C# Property Recursion

This repository demonstrates a potential stack overflow exception in C# due to recursive property modification within a method.  The `BuggyExample.cs` file shows the problematic code, where the `Value` property is updated within the `DoSomething` method, potentially leading to infinite recursion if the condition `Value > 10` remains true after each increment.

The `FixedExample.cs` file offers a corrected version, avoiding the recursive property change and preventing the stack overflow.