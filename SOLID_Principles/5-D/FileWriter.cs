using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._5_D
{
    public class FileWriter : IWriter, IDisposable
    {
        private readonly StreamWriter _streamWriter;

        public FileWriter(string filePath)
        {
            _streamWriter = new StreamWriter(filePath);
        }        

        public void Write(char character)
        {
            _streamWriter.Write(character);
        }

        public void Dispose()
        {
            _streamWriter.Dispose();
        }
    }
}