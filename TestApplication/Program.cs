using System;
using System.Linq;
using And3k5.ConsoleExtensions;
using And3k5.ConsoleExtensions.Colors;

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

            var colors = ConsoleXt.GetAllConsoleColors().Where(x => x.ToColor().GetSaturation() > 0.1)
                .OrderBy(x => x.ToColor().GetHue());
            foreach (var color in colors)
            {
                ConsoleXt.Fg(color).WriteLine(new string('█', Console.WindowWidth)).ResetColor();
            }

            ConsoleXt.WriteLine();

            Console.WriteLine("Hello World!");
        }
    }
}