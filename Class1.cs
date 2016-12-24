using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class TestClass<T>
    {
        private T a; // Declared private so is not accesible by other classes
        public TestClass(T t)
        {
            a = t;
        }
        public void Write()
        {
            Console.WriteLine(this.a);
        }
    }
}
