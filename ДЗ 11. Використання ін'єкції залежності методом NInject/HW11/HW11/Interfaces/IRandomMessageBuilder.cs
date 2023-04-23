using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Interfaces
{
    public interface IRandomMessageBuilder
    {
        void AddDateTime();
        void AddGreeting();
        void AddName();
        string Result();

    }
}
