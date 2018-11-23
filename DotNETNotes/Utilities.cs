using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETNotes
{
    public static class Utilities
    {
        public static void PrintStart(string str) => Console.WriteLine($"Start {str.PadRight(40, '=')}");

        public static void PrintEnd(string str) => Console.WriteLine($"End {str.PadRight(40, '=')}");
    }
}
