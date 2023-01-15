Console.WriteLine("введите число");
int A = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count <= (A-2))
{
      count = count + 2;
      Console.WriteLine($"{count}");
}
