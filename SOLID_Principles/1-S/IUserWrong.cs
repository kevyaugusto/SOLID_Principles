using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SRP
{
    interface IUserWrong
    { 
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
        void LogError(string error);
        bool SendEmail(string emailContent);
    }
}
