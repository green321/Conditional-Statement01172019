/*
 Author: Yue Xu
 Date: 01/17/2019
 Comments:Ask the user what grade they expect to get in ISM 4300. They should enter an integer value.
          Based on what the user has entered, have the program display their Letter grade per Syllabus for this course.
 */

using System;

namespace Conditional_Statement01172019
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for input
            Console.WriteLine("Please enter your grade that you expect to get in ISM 4300");

            //use to try catch block to validate user input
            //if user provide a bad input, the catch block will
            //show a error message. 
            try
            {
                //the variable will gather the user input
                string INPUT = Console.ReadLine();

                //the variable will be used to store grade after input variable is parsed to integer
                int GRADE = int.Parse(INPUT);

                //IF/ELSE IF/ELSE statement is used to conditional test
                if((GRADE>97)&&(GRADE<101))
                {
                    Console.WriteLine("Your final letter grade is A+");
                    Console.ReadKey(true);
                }
                else if((GRADE>91)&&(GRADE<98))
                {
                    Console.WriteLine("Your final letter grade is A");
                    Console.ReadKey(true);
                }
                else if ((GRADE > 89) && (GRADE < 92))
                {
                    Console.WriteLine("Your final letter grade is A-");
                    Console.ReadKey(true);
                }
                else if ((GRADE > 87) && (GRADE < 90))
                {
                    Console.WriteLine("Your final letter grade is B+");
                    Console.ReadKey(true);
                }
                else if ((GRADE > 81) && (GRADE < 88))
                {
                    Console.WriteLine("Your final letter grade is B");
                    Console.ReadKey(true);
                }
                else if ((GRADE > 79) && (GRADE < 82))
                {
                    Console.WriteLine("Your final letter grade is B-");
                    Console.ReadKey(true);
                }
                else if ((GRADE > 77) && (GRADE < 80))
                {
                    Console.WriteLine("Your final letter grade is C+");
                    Console.ReadKey(true);
                }
                else if ((GRADE > 71) && (GRADE < 78))
                {
                    Console.WriteLine("Your final letter grade is C");
                    Console.ReadKey(true);
                }
                else if ((GRADE > 69) && (GRADE < 72))
                {
                    Console.WriteLine("Your final letter grade is C-");
                    Console.ReadKey(true);
                }
                else if ((GRADE > 67) && (GRADE < 70))
                {
                    Console.WriteLine("Your final letter grade is D+");
                    Console.ReadKey(true);
                }
                else if ((GRADE > 61) && (GRADE < 68))
                {
                    Console.WriteLine("Your final letter grade is D");
                    Console.ReadKey(true);
                }
                else if ((GRADE > 59) && (GRADE < 62))
                {
                    Console.WriteLine("Your final letter grade is D-");
                    Console.ReadKey(true);
                }
                else if(GRADE>100)
                {
                    Console.WriteLine("Please enter the integer number lower than 100");
                    Console.ReadKey(true);
                }
                else 
                {
                    Console.WriteLine("Your final letter grade is F");
                    Console.ReadKey(true);
                }
            }//end of try

            catch
            {
                Console.WriteLine("Please use an integer data type for your grade");
                Console.WriteLine("Press any key to exit the program and try again");
                Console.ReadKey(true);

            } //end of catch

        }// end of main

    }// end of class

}// end of namespace
