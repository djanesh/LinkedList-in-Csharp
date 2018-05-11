using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace linked_list1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> list = new List<string>;
            list.Add("hello");
            */

            LinkedList list = new LinkedList();

            /*
            Console.WriteLine("is it empty? - " + list.Empty);
            Console.WriteLine("size - " + list.Count);
            Console.ReadLine();
            */

            //int index = list.IndexOf("hello");

            /*
            list.Add("Test1");

            int index = list.IndexOf("Test1");

            bool contains = list.Contains("Test1");
            list.Add("Test2");
            list.Add(1, "Test3");
            list.Add(1, "Test4");

            list.Remove(1);
            //list.Clear();
            */

            list.Add("Hello");
            list.Add("Test1");
            list.Add("Test2");

            object test = list[2];
        }
    }
}
