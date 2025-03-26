using System;
using System.Transactions;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}

//Line by line comment --- Ctrl + K, then Ctrl + C = Comment --- Ctrl + K, then Ctrl + U = Uncomment
/*Multiple line comment --- Toggle Block Comment Ctrl + Shift + */