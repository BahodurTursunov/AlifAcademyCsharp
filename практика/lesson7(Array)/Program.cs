
// 1.
int[] array1 = new int[3];

array1[0] = 1000;
array1[1] = 2000;
array1[2] = 5000;

Console.WriteLine(array1[3]);

// 2.
int[] array2 = new int[] { 1, 2, 3, 4, 5, 100, 100000, 5 };

// 3.
int[] array3 = { 1, 3, 45, 54, 234, 54 };

// While.

int i = 0;
while (i < array1.Length)
{
    Console.WriteLine(array1[i]);
    i++;
}

// Inline Array.

MyInlineArray inlineArray = new();

inlineArray[0] = 10;
inlineArray[1] = 10;
inlineArray[2] = 10;
inlineArray[3] = 10;
inlineArray[4] = 10;
inlineArray[5] = 10;
inlineArray[6] = 10;
inlineArray[7] = 10;
inlineArray[9] = 10;

[System.Runtime.CompilerServices.InlineArray(length: 10)]
public struct MyInlineArray
{
    private int _element;
}