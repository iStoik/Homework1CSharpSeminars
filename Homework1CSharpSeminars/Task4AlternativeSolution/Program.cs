Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int rem = 1;
while (rem <= num)
{
    if (rem % 2 == 0)
    {
        Console.Write(rem + " ");
    }
    rem++;
}