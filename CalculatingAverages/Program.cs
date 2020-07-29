using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CalculatingAverages
{
    class Program
    {

        static void Main(string[] args)
        {
            ////Basic Difficulty
            ////Sum of numbers
            ////Create a console application that will accept ten numbers 
            ////between 0 and 100, and reports their sum.

            int i, n;
            int sum = 0;

            Console.WriteLine("\nInput the 10 numbers");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine("\nThe sum is: {0}", sum);
        }
        public void Taketen(string[] args)
        {    //Average ten scores
             //Create a console application that will accept ten test scores between 0 and 100, 
             //average them, and report letter grade for the average based on the usual scale.For example, 
             //a teacher will input ten test scores and 
             //see the average numerical grade and the letter grade.

            int i, n;
            int sum = 1;
            int average;
            Console.WriteLine("\nInput the 10 grades.");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number {0}: ", i);
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 100 && n > 0)
                {
                    sum += n;
                }
                else
                {
                    Console.WriteLine("\nEnter correct value.");
                    i--;
                }
            }
            Console.WriteLine("\nThe average numerical grade is: {0}.", average = (sum - 1) / 10);

            string letterGrade;
            if (average <= 59)
            {
                letterGrade = "F";
            }
            else if (average <= 69)
            {
                letterGrade = "D";
            }
            else if (average <= 79)
            {
                letterGrade = "C";
            }
            else if (average <= 89)
            {
                letterGrade = "B";
            }
            else if (average <= 100)
            {
                letterGrade = "A";
            }
            else
            {
                letterGrade = "Unknown.";
            }
            Console.WriteLine($"\nThe letter grade is: {letterGrade}.");
            Console.ReadKey();
        }

        //Intermediate Difficulty
        //Average a specific number of scores
        //Create a console application that will accept an arbitrary number test scores (as specified by the user) 
        //between 0 and 100, average them, and report a letter grade for the average based on the usual scale.For example, 
        //a teacher will input the total number of tests, then input ten test scores and see the average numerical grade and the letter grade.
        void Intermediate(double)
        {
            Console.WriteLine("\n \nLet me help you figure out your average score and average grade");

            Console.WriteLine("Please enter how many scores you have");
            double amountOf = double.Parse(Console.ReadLine());

            double[] a = new double[(int)amountOf];

            Console.Write("\n\nNow enter your scores\n");
            Console.Write("--------------------------\n");

            for (int i = 0; i < amountOf; i++)
            {
                Console.Write("Please enter a score : ", i);
                a[i] = double.Parse((Console.ReadLine()));  
            }

            double sum = a.Sum();

            Console.Write("\n\n");

            double avg = sum / amountOf;

            Console.WriteLine($"This is the average numerical grade: \n {avg}");

            if (avg >= 97 && avg <= 100)
            {
                Console.WriteLine("This is your grade average: \n A+");
            }
            else if (avg >= 94 && avg <= 96)
            {
                Console.WriteLine("This is your grade average: \n A");
            }
            else if (avg >= 90 && avg <= 93)
            {
                Console.WriteLine("This is your grade average: \n A-");
            }
            else if (avg >= 87 && avg <= 89)
            {
                Console.WriteLine("This is your grade average: \n B+");
            }
            else if (avg >= 84 && avg <= 86)
            {
                Console.WriteLine("This is your grade average: \n B");
            }
            else if (avg >= 80 && avg <= 83)
            {
                Console.WriteLine("This is your grade average: \n B-");
            }
            else if (avg >= 77 && avg <= 79)
            {
                Console.WriteLine("This is your grade average: \n C+");
            }
            else if (avg >= 74 && avg <= 76)
            {
                Console.WriteLine("This is your grade average: \n C");
            }
            else if (avg >= 70 && avg <= 73)
            {
                Console.WriteLine("This is your grade average: \n C-");
            }
            else if (avg >= 68 && avg <= 69)
            {
                Console.WriteLine("This is your grade average: \n D+");
            }
            else if (avg >= 66 && avg <= 67)
            {
                Console.WriteLine("This is your grade average: \n D");
            }
            else if (avg >= 60 && avg <= 65)
            {
                Console.WriteLine("This is your grade average: \n D-");
            }
            else if (avg <= 59)
            {
                Console.WriteLine("This is your grade average: \n F");
            }
            else
            {
            
        }


            /*Advanced Difficulty
            Average a non-specific number of scores
            Create a console application that will accept a number test scores (as calculated by the number of scores 
            actually entered) between 0 and 100, average them, and report a letter grade for the average based on the usual scale.
            For example, a teacher will input any number test scores, and see the average numerical grade and the letter grade.*/
            string entry;
            string letterGrade;
            double total = 0;
            int numbers = 0;
            int i;
            Console.WriteLine("\t\tGRADEBOOK\n\n\n\tInsert grades followed by the enter key. \n Once you are done hit enter again and the GRADEBOOK\n will provide the average and letter grade.\n\n\n");
           
            while ((entry = Console.ReadLine()) != "")
            {
                total += double.Parse(entry);
                numbers++;
            }
            double average = total / numbers;

            if (average <= 59)
            {
                letterGrade = "F";
            }
            else if (average <= 69)
            {
                letterGrade = "D";
            }
            else if (average <= 79)
            {
                letterGrade = "C";
            }
            else if (average <= 89)
            {
                letterGrade = "B";
            }
            else if (average <= 100)
            {
                letterGrade = "A";
            }
            else
            {
                letterGrade = "Unknown.";
            }
            Console.WriteLine($"\nGrade: {average} {letterGrade}.");
            Console.ReadKey();


        }
    }
}
