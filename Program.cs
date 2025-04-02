using System;
using System.Runtime.ConstrainedExecution;
using System.Transactions;


namespace HelloWorld
{
    class Program
    {
/*        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Let's play Roblox");

            Console.WriteLine("Enter Username");
            string 
                User = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string
                Pass = Console.ReadLine();
            
            Console.WriteLine
                ("Username is: " +  User);
            Console.WriteLine
                ("Password is: " + Pass);
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Pick any number from 1-5");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int day))
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    default:
                        Console.WriteLine("Number of day doesn't exist");
                        break;
                }
            }
            else 
            {
                Console.WriteLine("Number of day doesn't exist");
            }

        }
    }
}

//Line by line comment --- Ctrl + K, then Ctrl + C = Comment --- Ctrl + K, then Ctrl + U = Uncomment
/*Multiple line comment --- Toggle Block Comment Ctrl + Shift + / */