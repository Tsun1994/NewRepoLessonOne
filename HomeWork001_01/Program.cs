Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("первое число больше второго");
}
else if (number1 < number2)
{
    Console.Write("второе число больше первого");
}
else 
{
    Console.Write("числа равны");
}