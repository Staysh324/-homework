//ввод двух чисел и вывод, какое максимальное
Console.WriteLine("введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA<numberB)
{
    Console.WriteLine($"число {numberB} больше числа {numberA}");
}
else
{
    Console.WriteLine($"число {numberA} больше числа {numberB}");
}