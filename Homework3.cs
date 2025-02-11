namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
    // Code for Q1
        Console.WriteLine("Input an integer: ");
        int N = Convert.ToInt16(Console.ReadLine());
          
        if (N <= 1)
        {
            Console.WriteLine("N is non-prime");
        }
        else
        {
            bool isPrime = true;

            for (int i = 2; i < N; i++)
        {
            if(N % i == 0)
            {
                isPrime = false; 
                break;
            }
         }
          if (isPrime)
            Console.WriteLine($"N is prime");
        else
            Console.WriteLine($"N is non-prime");
        }             



    //Code for Q2

        Console.WriteLine("Assign an int value to N: ");
        int N = Convert.ToInt16(Console.ReadLine());

        for(int row = 0; row<5; row++){

            for(int col = 0; col<5; col++)
            {
                Console.Write('#');
            }
            Console.WriteLine("");
        }
    

    //Code for Q3

        Console.WriteLine("Assign an int value to N: ");
        int N = Convert.ToInt16(Console.ReadLine());
        
        for(int row = 0; row<5; row++){
            for(int col = 0; col<5; col++)
            {
                if(row>=col)
                Console.Write('*');
            }
            Console.WriteLine("");
        }
     

    //Bonus question 
        Console.WriteLine("Assign an int value to N: ");
        int N = Convert.ToInt16(Console.ReadLine());
        
        for(int row = 1; row <= N; row++)
        {
            for(int col = 1; col <= row; col++)
            {
                
                Console.Write(row);
            }
            Console.WriteLine();
        }
    }
}
