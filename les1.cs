//a+b, a-b, a*b, a/b
short a = short.Parse(Console.ReadLine());

short b = short.Parse(Console.ReadLine());

Console.WriteLine("a+b=" + (a + b));

Console.WriteLine("a-b=" + (a - b));

Console.WriteLine("a*b=" + (a * b));

Console.WriteLine("a*b=" + ((float)a / b));

Console.ReadLine();


//task2
Console.WriteLine("How are you?");

string answer;
answer = Console.ReadLine();

Console.WriteLine("You are {0}", answer);

Console.ReadLine();

////task3
char char1 = Console.ReadLine().ToCharArray()[0];

char char2 = Console.ReadLine().ToCharArray()[0];

char char3 = Console.ReadLine().ToCharArray()[0];

Console.WriteLine("You enter {0}, {1}, {2}", char1, char2, char3);

Console.ReadLine();



//task4
Console.WriteLine("enter number");
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

if (c > 0 && d > 0)
{
    Console.WriteLine("all numbers good");
}
else
{
    Console.WriteLine("One or more numbers not good");
}
Console.ReadLine();

//home work 1.1
Console.WriteLine("enter a");
int e = int.Parse(Console.ReadLine());//string to int
Console.WriteLine("perimeter of area " + (e * e));
Console.WriteLine("perimeter of square " + (e * 4));
Console.ReadLine();

//home work 1.2
string name;
int age;
Console.WriteLine("What is your name?");
name = Console.ReadLine();
Console.WriteLine("How old are you,{0}?", name);
age = int.Parse(Console.ReadLine());
Console.WriteLine("{0} is {1} years old", name, age);
Console.ReadLine();

//home work 1.3
///length (l=2*pi*r), area (S=pi*r*r), and volume (4/3*pi*r*r*r) of a circle
Console.WriteLine("enter r number");
double r = double.Parse(Console.ReadLine());
double pi = 3.14;
Console.WriteLine("length {0}", 2 * pi * r);
Console.WriteLine("area {0}", pi * r * r);
Console.WriteLine("volume {0}", 4 / 3 * pi * r * r * r);
Console.ReadLine();