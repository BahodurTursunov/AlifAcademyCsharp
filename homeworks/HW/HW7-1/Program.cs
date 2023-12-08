//. Напишите программу, которая проверяет, содержится ли заданное число в массиве.

int[] arr = { 2, 3, 4, 5, 6, 5, 4, 3, 2, 3, 45, 56, 6, 45, 4 };
int isHaveNumInArr = int.Parse(Console.ReadLine());
int counter = 0;

foreach (var num in arr)
{
    if (isHaveNumInArr == num)
    {
        counter++;
    }
}
Console.WriteLine($"Заданное число в массиве встречается {counter} раза");

// 2 вариант
//for (int i = 0; i < arr.Length; i++)
//{
//    if (isHaveNumInArr == arr[i]) counter++;
//}
//Console.WriteLine($"Заданное число в массиве встречается {counter} раза");