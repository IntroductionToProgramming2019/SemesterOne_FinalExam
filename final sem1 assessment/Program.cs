/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : Year One Semester One Final Exam
 * 
 * ############################# */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_sem1_assessment
{
    class Program
    {
        static string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        static int[] otHoursPerDay = new int[7];
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // ask for the name of the user
            Console.Write("Please enter the employee's name >>");
            string name = Console.ReadLine();
            //refer to this method to print the first heading 
            PrintHeading(name);
            //refer to the method to ask the user to enter values for each each for the number of hours they worked
            EnterOvertime(name);
            //spacing
            Console.WriteLine();
            //header
            Console.WriteLine("========Printing Overtime===========");
            //refers to the method that reads in and prints out all the overtime hours asked for by the method "EnterOvertime();"
            PrintOvertime(name);
            //spacing
            Console.WriteLine();
            //stores the value calculated in " CalculateTotalOvertime();" as a double for use in later calculations. if it were stored as an int this would result in inaccurate calculations
            double totalOverTime = CalculateTotalOvertime();
            Console.WriteLine("Total Overtime: {0} hours", totalOverTime);
            Console.WriteLine();
            double averageOt = CalculateAverageOvertime(totalOverTime);
            Console.WriteLine("Average Daily Overtime: {0:0.00} hours", averageOt);
            Console.WriteLine();
            Console.WriteLine("========= Get Overtime For Specific Day ====");
            Console.Write("Please enter a day>>");
            string day = Console.ReadLine();
            int getspecificday = GetOTForDay(day);
            Console.WriteLine("Overtime for {0} is {1} hour(s)", day, getspecificday);
            Console.WriteLine();
            Console.WriteLine("========== Calculate Overtime Bill =======");
            Console.Write("Please enter an hourly rate >> ");
            double rate = double.Parse(Console.ReadLine());
            double bill = CalculateOverTimeBill(rate, totalOverTime);
            Console.WriteLine("Overtime bill for {0} is {1:C}", name, bill);



        }
        static void PrintHeading(string name)
        {
            string nameOfWorker = name;
            Console.WriteLine("========== Overtime for {0} =========", name);
            Console.WriteLine("========== Entering overtime hours =========");
        }
        static void EnterOvertime(string name)
        {
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.Write("Enter the number of overtime hrs for {0} >> ", daysOfWeek[i]);
                otHoursPerDay[i] = int.Parse(Console.ReadLine());
            }
        }
        static void PrintOvertime(string name)
        {
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                if (otHoursPerDay[i] > 1)
                {
                    Console.WriteLine("Overtime hours for {0} is {1} hours", daysOfWeek[i], otHoursPerDay[i]);
                }
                else
                {
                    Console.WriteLine("Overtime hours for {0} is {1} hour", daysOfWeek[i], otHoursPerDay[i]);
                }
            }
        }
        static double CalculateTotalOvertime()
        {
            Console.WriteLine("========== Calculating Total Overtime =======");
            double total = 0;
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                total = total + otHoursPerDay[i];
            }
            return total;

        }
        static double CalculateAverageOvertime(double totalOverTime)
        {
            Console.WriteLine("========== Calculating Average Overtime ===== ");
            double average = totalOverTime / daysOfWeek.Length;
            return average;
        }
        static int GetOTForDay(string day)
        {
            int answer = 0;
            string specificDay = day;
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                if (specificDay == daysOfWeek[i])
                {
                    answer = otHoursPerDay[i];
                }
                else
                {

                }
            }
            return answer;
        }
        static double CalculateOverTimeBill(double rate, double totalOverTime)
        {
            double overtimeBill = rate * totalOverTime;
            return overtimeBill;
        }
    }
}
