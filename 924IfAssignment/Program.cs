using System;

namespace _924IfAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
              //how to ask a user to enter a number (assignment on slide 89)
                Console.Write("Enter an integer: ");
            var answer = Console.ReadLine();
            var value = Convert.ToInt32(answer);
           
            if (value % 2 == 0) //if put quality check with modulo value, becomes a boolean expression
            { Console.WriteLine("The Number is Even"); }
            else 
            { Console.WriteLine("The number is Odd."); }

                 





        }
    }
}
