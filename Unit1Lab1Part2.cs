using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //variables declared here
            DateTime date1;
            DateTime date2;

            //gets user input for first date
            Console.WriteLine("Enter the first date in dd/mm/yyyy format: ");
            date1 = Convert.ToDateTime(Console.ReadLine()).Date;
           
            Console.WriteLine("");

            //gets user input for second date
            Console.WriteLine("Enter the second date in dd/mm/yyyy format: ");
            date2 = Convert.ToDateTime(Console.ReadLine()).Date;

            //Calculates and prints difference between two dates
            TimeSpan difference = date2.Subtract(date1);
            Console.WriteLine("");
            Console.WriteLine("The difference between these 2 dates = "
                + difference.Days / 365 + " years, " + difference.Days/30 + " months, "
                + difference.Days + " days, " + difference.Days * 24 
                + " hours, and " + difference.Days * 24*60 + " minutes");


            //Pauses before application close
            Console.WriteLine("Press any key to exit . . .");
            Console.ReadKey();

        }
    }
}


/*
                        maggie was here :D
*/