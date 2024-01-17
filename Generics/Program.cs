using System;
using System.Collections.Generic;

namespace Generics
{
     class Program
    {
        static void Main(string[] args)
        {
          
         List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Ankara");
            cities.Add("Ankara");
            cities.Add("Ankara");
            cities.Add("Ankara");
            Console.WriteLine(cities.Count);

            MyList<string> cities2 = new MyList<string>();
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            cities2.Add("Ankara");

           


        }
    }

    public class MyList<T> //Generic Class
    {

        private class Node
        {
          public Node (T t)
            {
                next = null;
                data = t;
            }

            private Node? next;
            public Node? Next
            {
                get { return next; }
                set { next = value; }
            }

            private T data;

            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }

        private Node? head;

        public MyList()
        {
            head = null;
        }

        public void Add(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node? current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }


    }


}
