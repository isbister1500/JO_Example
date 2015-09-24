using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleDataStructures;

namespace JO_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create and Add Elements
            SimpleLinkedList list = new SimpleLinkedList();
            list.Add("First element to Add"); 
            list.Add(2);
            list.Add("Some String");
            list.Add(998877);
            list.Add(true);
            list.Add(4F);
            list.Add(new DateTime(1988, 9, 7));

            //Print those elements
            list.Print();

            //Delete some elements & print
            list.Delete(0);
            list.Print();

            list.Delete(5);
            list.Print();

            list.Delete(1);
            list.Print();

        }

    }
}
