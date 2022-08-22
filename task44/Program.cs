// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// 
// +

// Console.WriteLine("Введите число N");
// int num1 = int.Parse(Console.ReadLine()!);
// int num2 = num1 - 2;

// int SIZE = num2;
// const int LEFT_RANGE = 1;
// const int RIGHT_RANGE = 1000;

// int[] array = ArrayF(SIZE, LEFT_RANGE, RIGHT_RANGE);
// Console.WriteLine($"Последовательность Фибоначи: 0 1 {string.Join(" ", array)}");

// int[] ArrayF(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         int temp = array[i];
//         array[i] = array[i-1] + array[i -2];
//     }
//     return array;
// }



Console.WriteLine("Введите число N");
int num1 = Convert.ToInt32(Console.ReadLine());
int[] arrF = new int[num1];

arrF[0] = 0;
arrF[1] = 1;

for (int i = 2; i < arrF.Length; i++)
{
    arrF[i] = arrF[i - 1] + arrF[i - 2];
}
Console.WriteLine($"Последовательность Фибоначи: {string.Join(" ", arrF)}");