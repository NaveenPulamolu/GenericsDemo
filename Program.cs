using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass<int> test1 = new TestClass<int>(25);//adding int data to generic
            test1.Write();
            TestClass<string> test2 = new TestClass<string>("Naveen");// adding string data to generic
            test2.Write();
            Console.ReadLine();
        }
    }
}
