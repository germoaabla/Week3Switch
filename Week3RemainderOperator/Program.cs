//odd or even

Console.WriteLine("Enter a number:");

int a = Convert.ToInt32(Console.ReadLine());

int result = a % 2;

Console.WriteLine($"Remainder is {result}");

//if (result == 0)
//{
//    Console.WriteLine($"{a} is an even number");
//}
//else
//{
//    Console.WriteLine($"{a} is an odd number");
//}
switch (result)
{
    case 0:
        Console.WriteLine($"{a} is an even number");
        break;
    case 1:
        Console.WriteLine($"{a} is an odd number");
        break;
    default:
        Console.WriteLine("Invalid value");
        break;
}