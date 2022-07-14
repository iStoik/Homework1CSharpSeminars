int [] numbers = new int[3];
int i = 0;
int max = 0;
Console.WriteLine("Введите три числа, и узнайте, ");
Console.WriteLine("какое из них имеет максимальное значение.");
Console.Write("Введите первое число и нажмите ENTER: ");
numbers[0] = int.Parse(Console.ReadLine());
Console.Write("Введите второе число и нажмите ENTER: ");
numbers[1] = int.Parse(Console.ReadLine());
Console.Write("Введите третье число и нажмите ENTER: ");
numbers[2] = int.Parse(Console.ReadLine());
while (i < numbers.Length)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    i++;
}
Console.Write("Максимальное значение имеет число " + max);
