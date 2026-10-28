
Console.WriteLine("Class ID: 66579 | Registration ID: 12703 | Name: Orainab Khan | Submission Date: 28-10-2026");

Console.Write("Enter purchase amount: ");
double amount = Convert.ToDouble(Console.ReadLine());

double discount = 0;

if (amount >= 5000)
{
    discount = 20;
}
else if (amount >= 2000)
{
    discount = 10;
}

double discountAmount = amount * discount / 100;
double finalAmount = amount - discountAmount;

Console.WriteLine("Discount Percentage: " + discount + "%");
Console.WriteLine("Discount Amount: " + discountAmount);
Console.WriteLine("Final Payable Amount: " + finalAmount);
