Console.WriteLine("Введите число недели");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Это понедельник");
}
else 
if (number == 2)
{
    Console.WriteLine("Это вторник");
}
else 
if (number == 3)
{
    Console.WriteLine("Это среда");
}

else
if (number == 4)
{
    Console.WriteLine("Это четверг");
}
else
if (number == 5)
{
    Console.WriteLine("Это пятница");
}
else
if (number == 6)
{
    Console.WriteLine("Это Суббота");
}
else
if (number == 7)
{
    Console.WriteLine("Это воскресенье");
}
else
{
    Console.WriteLine("вы ошиблись числом, введите заново, я закрываю эту программу");
}