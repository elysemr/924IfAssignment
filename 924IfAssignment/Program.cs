using System;

namespace _924IfAssignment
{
    class Program
    {
        static void Main(string[] args)

        {
            //assignment slide 104
            //int [] type means array of integers
            int[] nbrs2 = {
            3023, 8760, 1112, 8232, 8107};
            var highest = 999;
            var lowest = 10000;
            var sum = 0;
            foreach (int nbr in nbrs2)
            {
                if (nbr < lowest) lowest = nbr;
                if (nbr < lowest) lowest = nbr;
                sum = sum + nbr;
            }
            var totalhigh = (sum - lowest);
             var totallow = (sum - highest);
            Console.Write($"The largest sum of the largest values in nbrs is {totalhigh} and the smallest some is {totallow}");

            //can also sort an array and then add
            //assignment slide 102, find highest and lowest numbers programmatically
            //first come up with thought process on how going to solve it without the computer
            /* int[] nbrs = {

   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,

   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,

   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,

   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,

   435, 643, 809, 874, 906, 620, 328, 369, 426, 561

};
             var highest = 0; //set lower than all the numbers in list
            var lowest = 1000; //set higher than all numbers in list

            foreach (int nbr in nbrs)
            {
                if (nbr > highest) //because set highest lower than all numbers, anything greater will be new highest
                { highest = nbr; }
                if (nbr < lowest)
                { lowest = nbr; }
            };
                Console.WriteLine($"Highest: {highest}; Lowest: {lowest}");
            //if don't know all the numbers in an array, set vars to the biggest and smallest possible numbers by 
            //typing int.MinValue and int.MaxValue */

            //can do an index
            /* var highest = nbrs[0];
            var lowest = nbrs[1000]; */

            //the way greg would make it so no comma at the end of the string
            /*var comma = "";
            for (int idx = 1; idx <= 25; idx++)
            {
                Console.Write($"{comma} {idx}"); //the first iteration prints the space and then it loops through the rest with comma as a comma
                    comma = ",";
            } //with original var outside of string, it gets left behind and new var value loops with value inside of loop */

            //assignment companies use in interview process
            //start with for loop that generates the first part and make sure it works, then most of the rest will be inside the for loop
            /* var total = 0; //have to come up with something to add numbers up into
             for (var idx = 1; idx <= 50; idx++)
                 if (idx % 5 == 0 || idx % 7 == 0) //we only want certain numbers so...
                 {
                     total = total + idx; //if that's true, we're going to take current value of total (0), and add idx to it
                 } */
            //continue statement ex
            /*var total = 0;
            for (var idx = 1; idx <= 50; idx++)
            {
                if (idx % 5 == 0)
                {
                    total = total + idx;
                    continue;
                }

                if (idx % 7 == 0)
                {
                    total = total + idx;
                }
            }
            Console.WriteLine($"Total is {total}"); */
            
            //can't do two separate statements because there would be some repeats that would get counted more than once
            //but could do a continue to skip certain numbers by not running second code and restarting

            /*for (var i = 1; i <= 25; i++)
                if (i == 25)
                Console.Write($"25");
                else Console.Write($"{i}, "); //if you want a period at the end of the string (my way) */

              //how to ask a user to enter a number (assignment on slide 89)
              //put assignment in slide 89 into a for loop
                /*for(var idx = 0; idx < 5; idx++) // ++ can be on either side here because not an assignment
                {
                Console.Write("Enter an integer: ");
                var answer = Console.ReadLine();
                var value = Convert.ToInt32(answer);
           
                if (value % 2 == 0) //if put quality check with modulo value, becomes a boolean expression
                { Console.WriteLine("The Number is Even"); }
                else 
                { Console.WriteLine("The number is Odd."); }

                } */
            

            //from slide 91, example of for statement
            /*
            for (var i = 0; i < 10; i++)
                Console.WriteLine($"i = {i}"); */


                 





        }
    }
}
