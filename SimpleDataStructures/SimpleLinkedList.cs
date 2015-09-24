using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDataStructures
{

    /// <summary>
    /// Simple implementation of a Linked List.
    /// Does not allow null Value to be added.
    /// </summary>
    public class SimpleLinkedList : IPrintable
    {
        public SimpleNode First { get; set; }
        public int Count { get; set; }

        /// <summary>
        /// Initialize list.
        /// </summary>
        public SimpleLinkedList()
        {
            this.First = null;
            this.Count = 0;
        }

        /// <summary>
        /// Add element to the end of the list.
        /// </summary>
        public void Add(Object newNodeValue)
        {
            if (newNodeValue == null)
                return;

            SimpleNode elementToBeAdded = new SimpleNode { Value = newNodeValue };

            if (this.First == null) //first element added
                this.First = elementToBeAdded;

            else
            { 
                SimpleNode lastElement = this.GetNodeAtIndex(Count - 1);// = elementToBeAdded;
                lastElement.NextNode = elementToBeAdded;
            }

            this.Count++;
        }

        /// <summary>
        /// Gets Node at specified index.
        /// <exception cref="IndexOutOfRangeException"/>
        /// </summary>
        public SimpleNode GetNodeAtIndex(int i)
        {
            if (i > this.Count - 1 || i < 0)
                throw new IndexOutOfRangeException();

            SimpleNode parser = this.First;

            for (int x = 0; x < i ;x++)
            {
                parser = parser.NextNode;
            }

            return parser;
        }

        /// <summary>
        /// Deletes Node at specified index
        /// </summary>
        public void Delete(int index)
        {
            if (index == 0) //Delete Head Node
            {
                SimpleNode nodeToDelete = GetNodeAtIndex(index);
                this.First = nodeToDelete.NextNode;
            }

            else //Delete Body Node
            {
                SimpleNode nodeBeforeDelete = GetNodeAtIndex(--index);
                SimpleNode nodeToDelete = nodeBeforeDelete.NextNode;
                nodeBeforeDelete.NextNode = nodeToDelete.NextNode;
            }

            this.Count--;
        }

        /// <summary>
        /// Prints contents of SimpleLinkedList
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Print SimpleLinkedList. Count = " + this.Count + ", Contents:");

            SimpleNode parser = this.First;
            while (parser != null)
            {
                parser.Print();
                parser = parser.NextNode;
            }

            Console.ReadLine();
        }
    }
}
