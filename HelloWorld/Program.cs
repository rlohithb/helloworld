using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello Lohith!!!");
            Console.WriteLine("What is your name? ");
            var name = Console.ReadLine();
            var t = DateTime.Now;
            Console.WriteLine($"Hello {name}, it's {t} now");
            //Console.ReadKey(true);
        }
    }
}
