// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// +

// Console.WriteLine("Укажате количество элементов массивов");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num1];
// Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(1, 100);
// }
// Console.WriteLine(string.Join(", ", array));

// int[] rearray = new int[num1];
// for (int i = 0; i < array.Length; i++)
// {
//     rearray[i] = array[array.Length-i-1];
// }
// Console.WriteLine(string.Join(", ", rearray));
// 
// +

const int SIZE = 5;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

int[] arr = RandomArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine($"Исходный массив {string.Join(", ", arr)}");
ReverseArray(arr);
Console.WriteLine($"Развернутый массив {string.Join(", ", arr)}");

int[] RandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
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

