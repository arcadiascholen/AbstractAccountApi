using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAccountApi
{
    public enum Origin
    {
        All,
        Wisa,
        Smartschool,
        Directory,
        Google,
        Other,
    }

    public interface ILog
    {
        void AddMessage(Origin origin, string message);
        void AddError(Origin origin, string message);
    }
}
