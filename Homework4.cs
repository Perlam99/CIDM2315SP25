namespace Homework4;

class Program
{
    static void Main()

    {
        /* //Q1 
        int a, b;

        Console.Write("Enter the first number: ");
        a = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        b = Convert.ToInt16(Console.ReadLine());

        int largest;
        if (a > b)
        {
            largest = a;
        }
        else 
        {
            largest = b;
        }
        Console.WriteLine("a = " + a + "; b =" + b);
        Console.WriteLine("The largest number is: " + largest);
    
       */

    //Q2

        Console.Write("N is: ");
        int N = Convert.ToInt16(Console.ReadLine());

        Console.Write("; shape is  ");
        string shape = Console.ReadLine().ToLower();

        if (shape == "left")
        {
            for (int row = 1; row<= N; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }    
        else if (shape == "right")    
        {
            for (int row = 1; row <= N; row++)
            {
                for (int space = 0; space < N - row; space++)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star<row; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }   
           
    }
}
