using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
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

            var dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Phrase");
            dt.Columns.Add("Developer slang");

            dt.Rows.Add(dt.NewRow().SetFields(1,"Foo",true));
            dt.Rows.Add(dt.NewRow().SetFields(1,"Bar",true));
            dt.Rows.Add(dt.NewRow().SetFields(1,"Baz",true));
            dt.Rows.Add(dt.NewRow().SetFields(1,"Catchphrase!",false));

            ConsoleXt.WriteLine(dt);

            var colorsLoop = Loop(ConsoleXt.GetAllConsoleColors().Where(x => x.ToColor().GetSaturation() > 0.1)
                .OrderBy(x => x.ToColor().GetHue())).GetEnumerator();
            
            var message = "Hello world. This is a rainbow effect.";
            
            var hasWritten = false;
            
            while (true)
            {
                Console.CursorLeft = 0;
                foreach (var ch in message)
                {
                    colorsLoop.MoveNext();
                    ConsoleXt.Fg(colorsLoop.Current).Write(ch).ResetColor();
                }
                Thread.Sleep(100);
            }   

        }

        private static IEnumerable<TItem> Loop<TItem>(IEnumerable<TItem> items)
        {
            while (true)
                foreach (var item in items)
                    yield return item;
        }
    }
}