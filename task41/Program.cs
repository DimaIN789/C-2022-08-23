// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// 
// Console.WriteLine("Укажате количество элементов массивов");
// int num1 = Convert.ToInt32(Console.ReadLine());
// 
// int[] arr1 = new int[num1];
// Console.WriteLine("Введите целые числа для заполнения массива");
// 
// for (int i = 0; i < arr.Length; i++)
// {
//    int arr1[i] = Convert.ToInt32(Console.ReadLine());
// }

Console.WriteLine("Укажате количество элементов массивов");
int num1 = Convert.ToInt32(Console.ReadLine());
int[] arr1 = new int[num1];
Random rand = new Random();

for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = rand.Next(-100, 100);
}

int count = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i] > 0)
    {
        count++;
    }
}
if (count > 0)
{
Console.WriteLine("В массиве: ");
Console.Write(string.Join(", ", arr1));
Console.WriteLine($" -> {count} чисел больше нуля.");
}
else
{
   Console.WriteLine("В массиве: ");
Console.Write(string.Join(", ", arr1));
Console.WriteLine($" нет чисел больше нуля."); 
}
