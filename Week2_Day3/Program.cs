using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Practice Problem One
            //FavoriteFoody("Bob", "Pizza");
            //FavoriteFoody("Mia", "Ice Cream");
            //FavoriteFoody("Beth", "Apples");

            //Console.WriteLine("Please enter a name");
            //string userName = Console.ReadLine();

            //Console.WriteLine("Please enter the best food ever!");
            //string userFood = Console.ReadLine();  


            //Practice Problem Two
            RetirementCalculator(24);




        }

        public static void RetirementCalculator(int userAge)
        {
            int retirementAge = Math.Max(0, 65 - userAge);
            //Math.Max(); returns the greater of two integers

            Console.WriteLine("The user will retire in " + retirementAge + " years");
        }





        public static void FavoriteFoody(string name, string food)
        {
            Console.WriteLine("************************************");
            Console.WriteLine(name + "'s favorite food is  " + food);
            Console.WriteLine();
        }

    

        public static void RetirementCalc(int userAge)
        {
            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());
            int retirement = 65 - age;

            Console.WriteLine("The user will retire in " + retirement + "years.");
        }



        public static double WageCalculator(double hoursWorked, double hourlyWage)
        {
            Console.WriteLine("Please enter how many hours you've worked this month");
            double hours = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter how much you make per hour");
            double wage = double.Parse(Console.ReadLine());
            double montlyWage = wage * hours;
            Console.WriteLine(montlyWage);
            return montlyWage;
        }

       
















        ////methods go outside Main, but on the same level
        //public static int Add(int firstNumber, int secondNumber)
        //{
        //    int sum = firstNumber + secondNumber;

        //    return sum;
        //}
    }
}
