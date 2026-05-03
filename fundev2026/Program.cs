Console.WriteLine("Enter customer type (Regular / Silver / Gold):");
string type = Console.ReadLine().ToLower();

Console.WriteLine("Enter bill value:");
double bill = Convert.ToDouble(Console.ReadLine());

double baseDiscount = 0;
double extraDiscount = 0;

if (type == "gold")
{
    baseDiscount = bill * 0.20;

    if (bill > 100)
        extraDiscount = bill * 0.05;
}
else if (type == "silver")
{
    baseDiscount = bill * 0.10;

    if (bill > 100)
        extraDiscount = bill * 0.03;
}
else if (type == "regular")
{
    baseDiscount = bill * 0.05;

    if (bill > 100)
        extraDiscount = bill * 0.02;
}
else
{
    Console.WriteLine("Unknown customer type");
    return;
}

double totalDiscount = baseDiscount + extraDiscount;
double finalPrice = bill - totalDiscount;

Console.WriteLine("Total discount: " + totalDiscount + " JD");
Console.WriteLine("Final price: " + finalPrice + " JD");