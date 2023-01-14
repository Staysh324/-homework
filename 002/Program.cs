Console.WriteLine("введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > numberB && numberA > numberC)
{Console.WriteLine($"максимальное число {numberA}");
}
if (numberB > numberA && numberB > numberC)
{Console.WriteLine($"максимальное число {numberB}");
}
if (numberC > numberB && numberC > numberA)
{Console.WriteLine($"максимальное число {numberC}");
}
    




