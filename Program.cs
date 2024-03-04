salom:
Console.Write("birinchi soni kriting = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("ikkinchi soni kriting = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" + , -, *, /");
string c = Convert.ToString(Console.ReadLine());
if(c == "+")
{
    Console.WriteLine(a + b);
}
if(c == "-")
{
    Console.WriteLine(a - b);
}
if(c == "*")
{
    Console.WriteLine(a * b);
}
if(c == "/")
{
    Console.WriteLine(a / b);
}
Console.WriteLine("Do you want to continue? yes or no");
string d = Convert.ToString(Console.ReadLine());
if (d == "yes")
{
    goto salom;
}
else if(d == "no")
{
    Console.WriteLine("ok");
}