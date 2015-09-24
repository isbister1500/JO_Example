using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDataStructures
{

    /// <summary>
    /// Inheriting members can print their contents.
    /// Should use ToString() but this is to demonstrate an Interface. 
    /// </summary>
    public interface IPrintable
    {
        void Print();
    }
}
