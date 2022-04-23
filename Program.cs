using System;

namespace LAB4ASS
{
    class Program
    {
        static void Main(string[] args)
        {
            // LAB 4 
            int num1 = 0;
            int num2 = 0;
            
           Console.WriteLine("Please enter two nubers: ");
           num1 = Convert.ToInt32(Console.ReadLine());
           num2 = Convert.ToInt32(Console.ReadLine());

            bool result = num1 + num2 <= 100;

           if(result)
           {
               Console.WriteLine(result);
           }
           else if(!result)
           {
               Console.WriteLine(result);
           }
        }
    }
}
