using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Ex04
{
    class MyCopyableClass
    {
        protected int myInt;

        public int ContainedInt
        {
            get { return myInt; }
            set { myInt = value; }
        }
        public MyCopyableClass GetCopy()
        {
            return (MyCopyableClass)MemberwiseClone();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCopyableClass obj1 = new MyCopyableClass();
            obj1.ContainedInt = 8;
            MyCopyableClass obj2 = obj1.GetCopy();
            obj2.ContainedInt = 88;
            Console.WriteLine(obj1.ContainedInt);
            Console.ReadKey();
        }
    }
}
