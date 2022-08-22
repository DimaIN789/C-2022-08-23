// Задача 45: Напишите программу, 
// которая будет создавать копию заданного массива с помощью поэлементного копирования.


Console.WriteLine("Укажате количество элементов массивов");
int num1 = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[num1];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(1, 100);
}
Console.WriteLine($"Исходный массив {string.Join(", ", arr)}");

int[] arr1 = new int[num1];
for (int i = 0; i < arr.Length; i++)
{
    arr1[i] = arr[i];
}

Console.WriteLine($"Копия исходного массива {string.Join(", ", arr1)}");

