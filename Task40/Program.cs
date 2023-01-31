// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с 
// сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


Console.Clear();
Console.Write("Введите строну а: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите строну b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите строну c: ");
double c = Convert.ToDouble(Console.ReadLine());
if ((a + b > c) && (b + c > a) && (a + c > b))
{
    Console.WriteLine("Треугольник");
}
else
    Console.WriteLine("Не треугольник");