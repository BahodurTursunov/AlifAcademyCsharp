using System.Runtime.CompilerServices;
int[] arr = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine(arr[2]);

MyInlineArray inlineArray = new();

inlineArray[0] = 10;
inlineArray[1] = 10;
inlineArray[2] = 10;
inlineArray[3] = 10;
inlineArray[4] = 10;
inlineArray[5] = 10;
inlineArray[6] = 10;

[System.Runtime.CompilerServices.InlineArray(length:10)]
public struct MyInlineArray
{
    private int element;
}