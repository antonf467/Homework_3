// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int size = ReadInt("Введите размерность массива: ");
// int [] num = new int[size];

// ArrayRandomNum(num);
// PrintArray(num);
// int result = 0;

// for (int i = 0; i < num.Length; i++)
// {
//     if (num[i] % 2 == 0)
//     {
//         result++;
//     }
// }
// if (result % 10 == 1)
// {
//     Console.WriteLine($"В массиве {result} четное число");
// }
// if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
// {
//     Console.WriteLine($"В массиве {result} четных числа");
// }
// else

//     Console.WriteLine($"В массиве {result} четных чисел");


// void ArrayRandomNum(int [] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(99, 999);
//     }
// }

// void PrintArray(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// int ReadInt(string mess) 
// {
//     Console.Write(mess);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//  стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0 

// int size = 4;
// int[] num = new int[size];
// ArrayRandomNumbers(num);
// PrintArray(num);

// int sumNumEvenIndex = 0;

// for (int i = 1; i < num.Length; i += 2)
// {
//  sumNumEvenIndex += numb[i];
// }
// Console.Write(sumNumEvenIndex);



// void ArrayRandomNum(int[] array)
// {
//  for (int i = 0; i < array.Length; i++)
//     {
//  array[i] = new Random().Next(-100, 101);
//     }
// }

// void PrintArray(int[] array)
// {
//  for (int i = 0; i < array.Length; i++)
//     {
//  Console.Write(array[i] + " ");
//     }
//  Console.WriteLine();
// }

// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
// //  элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}