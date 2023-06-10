Random rd = new Random();

Console.WriteLine("DZ zadacha 2:");
int input1 = 0;
int input2 = 0;
System.Console.WriteLine($"a={input1 = rd.Next(1, 100)}");
System.Console.WriteLine($"b={input2 = rd.Next(1, 100)}");
if (input1 > input2){
    System.Console.WriteLine($"max = {input1}");
}else{
    System.Console.WriteLine($"max = {input2}");
}