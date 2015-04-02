using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch08Ex02
{
    interface ICup
    {
        string Color { get; set; }
        string Volume { get; set; }
        void Refill();
        void Wash();
    }

    abstract class HotDrink
    {
        public bool Milk;
        public bool Sugar;
        public void Drink() { }
        public void AddMilk() { }
        public void AddSugar() { }

    }

    class CupOfCoffee : HotDrink, ICup
    {
        public string Color
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string Volume
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void Refill()
        {
            throw new NotImplementedException();
        }

        public void Wash()
        {
            throw new NotImplementedException();
        }

        public string BeanType;
    }

    class CupOfTea : HotDrink, ICup
    {
        public string Color
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string Volume
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void Refill()
        {
            throw new NotImplementedException();
        }

        public void Wash()
        {
            throw new NotImplementedException();
        }

        public string LeafType;
    }

    class Program
    {
        static void Main(string[] args)
        {

        }

        static void ManipulateDrink(HotDrink drink)
        {
            drink.AddMilk();
            drink.Drink();
            if (drink is ICup)
            {
                ICup cupInterface = drink as ICup;
                cupInterface.Wash();
            }
        }
    }
}
