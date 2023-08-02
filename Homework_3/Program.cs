// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

 Console.Write("Введите число : ");
  int X1 =Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число : ");
  int Y1 =Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число : ");
  int Z1 =Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число : ");
  int X2 =Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число : ");
  int Y2 =Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число : ");
  int Z2 =Convert.ToInt32(Console.ReadLine());
  double s=Math.Sqrt((Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2)+ Math.Pow((Y2-Y1),2)));
  System.Console.WriteLine(s);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число");
// int num =Convert.ToInt32(Console.ReadLine());

//  for(int i =1; i<=num; i++)
//  {
//  Console.WriteLine(Math.Pow(i,3));
 //}