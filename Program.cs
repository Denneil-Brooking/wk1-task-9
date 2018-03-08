using System;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("This Program list's members of the class");
            Console.WriteLine("------------------------------------------");

            var student = new string[] { "Human One", "Human Two", "Human Three", "Human four", "Human Five"};
            foreach (string value in student)
            {
                Console.WriteLine(value);
                Console.WriteLine("------------------------------------------");
            }

            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("**************PROGRAM END***************");
            Console.WriteLine("Please Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
