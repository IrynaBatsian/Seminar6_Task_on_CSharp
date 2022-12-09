// Напишите программу, которая на вход принимает три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

Console.Clear();
Console.Write("Введите длину первой стороны треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй стороны треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третьей стороны треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < (b + c) && b < (a + c) && c < (a + b))
  Console.WriteLine("YES");
else
  Console.WriteLine("NO");
