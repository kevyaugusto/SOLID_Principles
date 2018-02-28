using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._4_I
{
    /// <summary>
    /// Issue: Canon Printer does not send Fax (FaxContent() method) but because we have 
    /// a generic interface, it is required to implement this method FaxContent()
    /// </summary>
    class CanonPrinter : Interfaces.IPrinterOperations
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
