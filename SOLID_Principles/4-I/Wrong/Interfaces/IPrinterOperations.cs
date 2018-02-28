using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._4_I.Interfaces
{
    interface IPrinterOperations
    {
        bool PrintContent();
        bool ScanContent();
        bool PhotoCopyContent();
        bool FaxContent();

        /// <summary>
        /// BAD PRACTICE
        /// When uncomment this method PrintDuplexContent(), all classes which 
        /// depends on this interface will have implement this method
        /// </summary>
        /// <returns></returns>
        //bool PrintDuplexContent(); 

    }
}
