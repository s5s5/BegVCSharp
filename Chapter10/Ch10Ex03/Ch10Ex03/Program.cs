using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Ex03
{
    class MyClass
    {
        private string myString;

        public string ContainedString
        {
            set { myString = value; }
        }

        public virtual string GetString()
        {
            return myString;
        }
    }

    class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            return base.GetString() + " (output from derived class)";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.ContainedString = "s5s5";
            Console.WriteLine(myClass.GetString());

            MyDerivedClass myDerivedClass = new MyDerivedClass();
            myDerivedClass.ContainedString = "seedling";
            Console.WriteLine(myDerivedClass.GetString());
            
            Console.ReadKey();
        }
    }
}
