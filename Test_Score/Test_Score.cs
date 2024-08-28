// Test Score

class Program
{ 
    static void Main(string[] args) 
    {
        Console.Write("Input your test score: ");
        int score = Convert.ToInt32(Console.ReadLine());
        if (score < 60)
        {
            Console.WriteLine("F");
        }
        else if ((score >= 60) && (score < 69))
        {
             Console.WriteLine("D");
        } 
        else if ((score >= 70) && (score < 80))
            {
             Console.WriteLine("C");
        } 
        else if ((score >= 80) && (score < 90))
        {
             Console.WriteLine("B");
        }
        else if ((score >=90) && (score < 101))
        {  Console.WriteLine("A");}

        Console.ReadLine();
    }
}
