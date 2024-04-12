//Simple Calculator Program
/*
Console.WriteLine("This  is a simple calculator program\nChoose any of the four choices below\n1.Addition\n2.Subtraction\n3.Division\n4.Multiplication");
while (true)
{
    Console.WriteLine("Enter the first number");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your choice");
    int c = Convert.ToInt32(Console.ReadLine());
    if (c == 1)
    {
        int Sum = a + b;
        Console.WriteLine("The addition is : " + Sum);
    }
    else if (c == 2)
    {
        int diff = a - b;
        Console.WriteLine("The difference is : " + diff);
    }
    else if (c == 3)
    {
        int div = a / b;
        Console.WriteLine("The division is : " + div);
    }
    else if (c == 4)
    {
        int mult = a * b;
        Console.WriteLine("The multiplication is : " + mult);
        
        Console.WriteLine("Do you want to perform another operation");
        string again=Console.ReadLine();
         if (again != "yes")
         { break;
        }
    }
    
}
Console.ReadKey();

Console.WriteLine("What day is it today ? ");
String day=Console.ReadLine();
switch (day)
{
    case "Monday":
        Console.WriteLine("It's Monday !");
        break;
    case "Tuesday":
        Console.WriteLine("It's Tuesday !");
        break;
    case "Wednesday":
        Console.WriteLine("It's Wednesday !");
        break;
    default:
        Console.WriteLine(day +" "+ "is not a valid day");
        break;

}
Console.ReadKey();

Console.WriteLine("What is the temperature outside: (C)");
double temp=Convert.ToDouble(Console.ReadLine());
if (temp > 10 && temp <= 25)
{
    Console.WriteLine("It is cold outside");
}
else if (temp>25 && temp<32)
{
    Console.WriteLine("It is normal outside");
}
else if (temp>32)
{
    Console.WriteLine("It is warm outside");
}
Console.ReadKey();

Console.WriteLine("Enter your name");
string name=Console.ReadLine();
while (name == "")
{
    Console.WriteLine("Enter a valid name");
    name = Console.ReadLine();
}
Console.WriteLine("Welcome" + name);


Console.WriteLine("Enter a number for its multiplication table");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many multiples do you need");
int y= Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= y; i++)
{
    Console.WriteLine($"{number} * {i} = {number*i}");
}

Console.WriteLine("How many fibonacci terms to print");
int a = Convert.ToInt32(Console.ReadLine()) ;
int b = 0 ;
int c = 1;
int d = b + c ;
for (int i = 0; i < a; i++)
{
    if (c > b)
    {
        d = b + c;
        Console.WriteLine(d);
        b = d;
    }
    else
    {
        d = b + c;
        Console.WriteLine(d);
        c = d;
    }

  

string a = Console.ReadLine()!;
char[] b = a.ToCharArray();
Array.Reverse(b);
string c = new string(b);
if (a == c)
{
    Console.WriteLine($"{a} IS A PALINDROME");

}
else
{
    Console.WriteLine($"{a} IS NOT A PALINDROME");
}
while (true)
{
    Console.WriteLine("Enter a no to check whether it is even/odd: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a % 2 == 0)
    {
        Console.WriteLine($"{a} is a even no");
    }
    else
    {
        Console.WriteLine($"{a} is a odd no");
    }
}
*/


Console.WriteLine("Enter a no to check whether it is a prime no or not : ");
int a = Convert.ToInt32(Console.ReadLine());
bool isprime = true;
for (int i = 2; i < a; i++)
{
    if (a % i == 0)
    {
        isprime = false;
    }
}
if (isprime == true)
{
    Console.WriteLine($"{a} is a prime no");
}
else
{
    Console.WriteLine($"{a} is not a prime no");
}