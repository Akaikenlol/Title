using System;

namespace Title
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The current console title is:\"{0}\"", Console.Title);
            Console.ReadKey(true);
            Console.Title = "The title has changed!";
            Console.WriteLine("Note that the new console title is \"{0}\"\n"+"(press any key to quit.",Console.Title);
            Console.ReadKey(true);
        }
    }
}
