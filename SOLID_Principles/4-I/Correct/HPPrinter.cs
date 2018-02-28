using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._4_I.Correct
{
    class HPPrinter : Interfaces.IPrinterScanOperations, Interfaces.IPrinterFaxOperations
    {
        public bool FaxContent()
        {
            throw new NotImplementedException();
        }

        public bool PhotoCopyContent()
        {
            throw new NotImplementedException();
        }

        public bool PrintContent()
        {
            throw new NotImplementedException();
        }

        public bool ScanContent()
        {
            throw new NotImplementedException();
        }
    }
}
