int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
var c = Console.ReadLine();
if (c == "+")
{
    Console.WriteLine(a+b);
}
else if (c == "-")
{
    Console.WriteLine(a-b);
}
else
{
    Console.WriteLine("Недопустимое значение");
}

