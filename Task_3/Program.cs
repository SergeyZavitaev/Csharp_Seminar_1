Random rd = new Random();

Console.WriteLine("DZ zadacha 6:");
int input = 0;
System.Console.WriteLine(input = rd.Next(-10, 11));
if (input % 2 == 0)
{
    Console.WriteLine("Число чётное!");
}
else
{
    Console.WriteLine("Число не чётное!");
}