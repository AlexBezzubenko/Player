using System;

namespace app1
{
    class Program
    {
        public static string ShowMenu(bool menu_show)
        {
            if (menu_show)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("--print       Prints Questions and Answers");
                Console.WriteLine("--add         Adds Question");
                Console.WriteLine("--remove ID   Removes Question with ID");
                Console.WriteLine("--find ID     Prints Question with ID");
                Console.WriteLine("--menu on/off Shows or hides menu");
                Console.WriteLine("--start       Starts test");
                Console.WriteLine("--exit        Exit");
                Console.WriteLine("------------------------------------------");
            }
            return Console.ReadLine();
        }

        static void Main()
        {
            
        }
    }
}