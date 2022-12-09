// Написать программу, производящую согласно утверждению Гольдбаха, разложение заданного четного числа. Из всех пар простых чисел, сумма которых равно заданному числу, требуется найти пару, содержащую наименьшее простое число.


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int  countDel = 0;  // переменная для количества делителей
for (int i = 2; i <= n / 2; i++)
{
  countDel = 0;
  for (int j = 2; j <= i / 2 ; j++ )
  {
    if (i % j == 0)
      countDel++;
  }
  if (countDel == 0)
  {
    countDel = 0;
    int m = n - i;
    for (int k = 2; k <= (m + 1) / 2; k++)
    {
      if (m % k == 0)
        countDel++;
    }
    if (countDel == 0)
    {
        Console.WriteLine($"{i} {m}");
        return;
    }    
  }
}