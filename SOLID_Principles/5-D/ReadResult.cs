using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._5_D
{
    public class ReadResult
    {
        public readonly char Character;
        public readonly bool ShouldQuit;

        public ReadResult(char character, bool shouldQuit)
        {
            Character = character;
            ShouldQuit = shouldQuit;
        }
    }
}
