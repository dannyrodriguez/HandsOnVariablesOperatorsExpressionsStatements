using System;

namespace HandsOnVariablesOperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main method demonstrates the use of variables, operators, expressions, and statements
            //Variables for requirements
            int x = 3;
            int y = 4;
            int sum = x + y;
            String text1 = "Hello";
            String text2 = "World";
            String message = text1 + text2;


            //Screen outputs
            Console.WriteLine("Sum of " + x + " and " + y + " is:" + sum);
            Console.WriteLine("Are the values of sum and 7 equal? " + (sum == 7 ? true : false));
            Console.WriteLine("Message: " + text1 + " " + text2);
            Console.ReadLine();
        }
    }
}
