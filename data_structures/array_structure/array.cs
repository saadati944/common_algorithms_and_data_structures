using System;
using System.Collections;

namespace algos
{
    class Program
    {
        /// <summary>
        /// testing array class
        /// </summary>
        static void Main()
        {
            /*
             sample output :
                0, 1, 2, 3, 4, 
                removing...
                1, 3, 
                changing...
                2, 5, 
                create new array
                0, 1, 2, 3, 4, 5, 
                remove first, last and middle elements
                1, 2, 4, 
             */
            // add some elements
            Array a = new Array();
            a.Append(0);
            a.Append(1);
            a.Append(2);
            a.Append(3);
            a.Append(4);

            for (int i = 0; i < a.Length; i++)
                Console.Write($"{a[i]}, ");

            // remove elements
            Console.WriteLine("\nremoving...");
            a.Remove(22);
            a.Remove(0);
            a.Remove(4);
            a.Remove(2);
            a.Remove(4);

            for (int i = 0; i < a.Length; i++)
                Console.Write($"{a[i]}, ");

            // change elements with their index
            Console.WriteLine("\nchanging...");
            a[0] += 1;
            a[1] += 2;

            for (int i = 0; i < a.Length; i++)
                Console.Write($"{a[i]}, ");


            // test other abilities

            Console.WriteLine("\ncreate new array");
            Array b = new Array();

            b.Append(0);
            b.Append(1);
            b.Append(2);
            b.Append(3);
            b.Append(4);
            b.Append(5);

            //access array elements with enumerator
            foreach (int x in b)
                Console.Write($"{x}, ");

            Console.WriteLine("\nremove first, last and middle elements");
            b.RemoveAt(0);
            b.RemoveAt(b.Length - 1);
            b.RemoveAt(b.Length / 2);


            foreach (int x in b)
                Console.Write($"{x}, ");

        }
    }

    /// <summary>
    /// array data structure implemented in c#
    /// </summary>
    public class Array : IEnumerable
    {
        public int Length { get; private set; }
        private LinkedList _node;
   
        public Array()
        {
            this._node = null;
        }

        /// <summary>
        /// append new item to elements list
        /// </summary>
        /// <param name="value">item to append</param>
        public void Append(int value)
        {
            LinkedList tail = get_tail();
            if (tail is null)
                _node = new LinkedList(value);
            else
                tail.Next = new LinkedList(value);

            this.Length++;
        }

        /// <summary>
        /// remove an item from array elements
        /// </summary>
        /// <param name="value">item to remove</param>
        public void Remove(int value)
        {
            if (_node is null)
                return;

            LinkedList cur = _node;

            if (cur.Value == value)
                _node = cur.Next;

            LinkedList last = cur;
            while (cur is not null && cur.Value != value)
            {
                if (cur.Next is null && cur.Value == value)
                {
                    last.Next = null;
                    Length--;
                    return;

                }

                last = cur;
                cur = cur.Next;
            }

            if (cur == null) return;
            last.Next = cur.Next;
            Length--;
        }

        /// <summary>
        /// remove element with specific index
        /// </summary>
        /// <param name="index">index of element to remove</param>
        public void RemoveAt(int index)
        {
            if (_node is null)
                throw new IndexOutOfRangeException();

            if (index == 0)
                _node = _node.Next;

            int i = 0;
            LinkedList cur = _node, last = cur;
            while (i < index)
            {
                last = cur;
                cur = cur.Next ?? throw new IndexOutOfRangeException();
                i++;
            }

            last.Next = cur.Next;
            Length--;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.Length; i++)
                yield return this[i];
        }

        public int this[int index]
        {
            get
            {
                if (_node is null)
                    throw new IndexOutOfRangeException();
                int i = 0;
                LinkedList cur = _node;
                while (i < index)
                {
                    cur = cur.Next ?? throw new IndexOutOfRangeException();
                    i++;
                }

                return cur.Value;
            }
            set
            {
                if (_node is null)
                    throw new IndexOutOfRangeException();
                int i = 0;
                LinkedList cur = _node;
                while (i < index)
                {
                    cur = cur.Next ?? throw new IndexOutOfRangeException();
                    i++;
                }

                cur.Value = value;
            }
        }

        /// <summary>
        /// get tail of linked list to append new item to it
        /// </summary>
        /// <returns>the last item in the elements list</returns>
        private LinkedList get_tail()
        {
            if (_node is null)
                return null;
            LinkedList tail = _node;
            while (tail.Next is not null)
            {
                tail = tail.Next;
            }

            return tail;
        }
    }

    /// <summary>
    /// a simple linked list class
    /// </summary>
    public class LinkedList
    {
        public int Value;
        public LinkedList Next;

        public LinkedList(int value, LinkedList next = null)
        {
            this.Value = value;
            this.Next = next;
        }


    }
}