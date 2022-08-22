// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 
// +

Console.WriteLine("Введите десятичное число");
int num1 = int.Parse(Console.ReadLine()!);

int SIZE = (int)Math.Log2(num1) + 1;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 1;

int[] arr = Array(SIZE, LEFT_RANGE, RIGHT_RANGE);
ReverseArray(arr);
Console.WriteLine($"В двоичной системе будет так: {string.Join("", arr)}");

int[] Array(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num1 % 2;
        num1 = num1 / 2;
    }

    return array;
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}