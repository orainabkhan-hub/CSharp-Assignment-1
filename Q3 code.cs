
Console.WriteLine("Class ID: 66579");
Console.WriteLine("Registration ID: 12703");
Console.WriteLine("Name: Orainab Khan");
Console.WriteLine("Submission Date: 28-10-2026");

Console.Write("Enter year: ");
int year = Convert.ToInt32(Console.ReadLine());

if (year % 400 == 0)
{
    Console.WriteLine("Leap year");
}
else if (year % 100 == 0)
{
    Console.WriteLine("Not a leap year");
}
else if (year % 4 == 0)
{
    Console.WriteLine("Leap year");
}
else
{
    Console.WriteLine("Not a leap year");
}
