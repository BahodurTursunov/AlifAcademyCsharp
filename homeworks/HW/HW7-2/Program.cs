//2. Создайте массив чисел. Используя цикл, найдите и выведите сумму всех элементов массива.

int[] arr = { 5,5,2,3,4,56,7,89,9,7,6,45,43,3,2,12,23,4,5,6};

int sumNumOfArr = 0;

for (int i = 0; i < arr.Length; i++)
{
    sumNumOfArr += arr[i];
}
Console.WriteLine($"Сумма чисел в массиве равна {sumNumOfArr}");



