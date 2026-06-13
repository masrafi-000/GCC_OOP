using System;

class Program
{
    static void Main()
    {
       int n;

       Console.WriteLine("Enter a number: ");
       n = Convert.ToInt32(Console.ReadLine());

       if(n % 2 == 0)
        {
            Console.WriteLine(n + "is even");
        } else
        {
            Console.WriteLine(n + "is odd");
            
        }
    }
}