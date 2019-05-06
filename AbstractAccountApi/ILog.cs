using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAccountApi
{
    public interface ILog
    {
        void AddMessage(string message);
        void AddError(string message);
    }
}
