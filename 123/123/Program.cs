double a = double.Parse(Console.ReadLine());
var c = Console.ReadLine();
double b = double.Parse(Console.ReadLine());
if (c == "+")
{
    Console.WriteLine(a+b);
}
else if (c == "-")
{
    Console.WriteLine(a-b);
}
else if(c == "/")
{
    Console.WriteLine(a/b);
}
else if (c == "*")
{
    Console.WriteLine(a*b);
}
else
{
    Console.WriteLine("Недопустимое значение");
}

