using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._5_D
{
    public class ConsoleReader : IReader
    {
        public ReadResult Read()
        {
            var consoleKeyInfo = Console.ReadKey(true);

            return new ReadResult(consoleKeyInfo.KeyChar, consoleKeyInfo.Key == ConsoleKey.Escape);
        }
    }
}
