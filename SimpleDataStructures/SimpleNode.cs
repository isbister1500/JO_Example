using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDataStructures
{
    public class SimpleNode : IPrintable
    {
        public Object Value { get; set; }
        public SimpleNode NextNode { get; set; }

        public SimpleNode()
        {
            NextNode = null;
            Value = null;
        }

        /// <summary>
        /// Prints contents of SimpleNode
        /// </summary>
        public void Print()
        {
            Console.WriteLine("SimpleNode:" + this.Value.ToString());
        }
    }
}
