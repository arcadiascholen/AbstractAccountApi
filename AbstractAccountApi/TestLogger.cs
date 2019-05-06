using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAccountApi
{
    public class TestLogger : ILog
    {
        public void AddError(string message)
        {
            Debug.WriteLine("Error: "+ message);
        }

        public void AddMessage(string message)
        {
            Debug.WriteLine("Warning: " + message);
        }
    }
}
