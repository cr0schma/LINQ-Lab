// Create the following array
int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

//Find the Minimum value 
int minValue = nums.Min();
Console.WriteLine($"minValue: {minValue}");

//Find the Maximum value
int maxValue = nums.Max();
Console.WriteLine($"\nmaxValue: {maxValue}");

//Find the Maximum value less than 10000
var lessThan = (from x in nums where x < 10000 select x).Max();
Console.WriteLine($"\nMaximum value less than 10000: {lessThan}");

//Find all the values between 10 and 100
var between10And100 = from x in nums where x > 10 && x < 100 select x;
Console.WriteLine("\nAll the values between 10 and 100");
foreach (var item in between10And100)
{
    Console.WriteLine(item);
}

//Find all the Values between 100000 and 999999 inclusive
Console.WriteLine("\nAll the Values between 100000 and 999999 inclusive");
var between100000And999999 = from x in nums where x >= 100000 && x <= 999999 select x;
foreach (var item in between100000And999999)
{
    Console.WriteLine(item);
}

//Count all the even numbers 
var allEven = nums.Where(x => x % 2 == 0).Count();
Console.WriteLine($"\nCount of all even numbers {allEven}");
