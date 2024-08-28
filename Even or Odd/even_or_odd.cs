// 1. Even or Odd
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");


            Console.ReadLine();
        }
    }
}
