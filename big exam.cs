using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //input euro symbol
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //create string do you want to buy another (acronymed) to use sentinal values to control the while loop, y means yes and keeps loop active, n means no and ends the loop
            string dywtba = "y";
            //dywtba must be y to stay in the loop, after it goes through the loop 
            //each time it asks you to reassign dywtba to see whether to keep in the loop or end the program
            while (dywtba == "y")
            {
                //asks for and assigns name and age to be used in ticket price calculation
                Console.WriteLine("Please enter name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter age : ");
                int age = int.Parse(Console.ReadLine());
                //create a cost integer and calls a method that does the actual calculation of how much the ticket will be
                //assigned values name and age are passed down as arguements to be used in teh calculation
                int cost = CostOFTicket(name, age);
                //costs are displayed and teh use is asked whether they want to buy another
                Console.WriteLine("{0} the cost of your ticket is {1:c}", name, cost);
                Console.WriteLine("Do you wish to buy another (y / n) : ");
                dywtba = Console.ReadLine();
            }
        }
        static int CostOFTicket(string name, int age)
        {
            int cost = 0;
            if (age < 18)
            {
                cost = 10;
            }
            if ((age >= 18) && (age <= 21))
            {
                cost = 15;
            }
            else
            {
                cost = 20;
            }
            //the method put the user into a cost bracket depending on their age using if statements. the cost is then returned as an int
            return cost;
        }
    }
}
