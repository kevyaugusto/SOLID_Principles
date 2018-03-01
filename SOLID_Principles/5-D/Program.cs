using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._5_D
{
    class Program
    {
        void Main()
        {
            // Composition Root
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            
            //var writer = new FileWriter("text.txt");

            var copyProcess = new CopyProcess(reader, writer);
            copyProcess.Execute();
        }
    }
}