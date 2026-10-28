
Console.WriteLine("Class ID: 66579");
Console.WriteLine("Registration ID: 12703");
Console.WriteLine("Name: Orainab Khan");
Console.WriteLine("Submission Date: 28-10-2026");

Console.Write("Enter first number: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter operator (+, -, *, /): ");
char op = Convert.ToChar(Console.ReadLine());

if (op == '+')
{
    Console.WriteLine(a + b);
}
else if (op == '-')
{
    Console.WriteLine(a - b);
}
else if (op == '*')
{
    Console.WriteLine(a * b);
}
else if (op == '/')
{
    Console.WriteLine(a / b);
}
else
{
    Console.WriteLine("Invalid operator");
}
