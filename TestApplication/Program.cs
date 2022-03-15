using System;
using And3k5.ConsoleExtensions;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleXt
                .Fg(ConsoleColor.Red).Write("Hello ").ResetColor()
                .Fg(ConsoleColor.Cyan).Write("World").ResetColor()
                .Fg(ConsoleColor.Yellow).Write("!").ResetColor()
                .WriteLine();

            Console.WriteLine("Hello World!");
        }
    }
}
