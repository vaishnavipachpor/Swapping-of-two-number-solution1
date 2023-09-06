//write a program to swap two number without using third variable.
class SwapNumbers1   //solution 1
{
    static void Main()
    {
        int a = 342, b = 784;
        Console.WriteLine($"Nmuber before swap: a=> {a};b=> {b}");
        a = a * b; b = a / b; a = a / b;
        Console.WriteLine($" Number after swaping :a=>{a};b=>{b}");
        Console.ReadLine();
    }
}