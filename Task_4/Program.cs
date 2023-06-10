Random rd = new Random();

Console.WriteLine("DZ zadacha 8:");
int input = 0;
Console.WriteLine(input = rd.Next(1,100));
int count = (input / 2);
for (int index = 1; index <= count; index++)
{
    Console.Write($"{index * 2}, ");
}