﻿using System;

namespace Ch11Ex01
{
    public abstract class Animal
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal()
        {
            name = "The animal with no name";
        }

        public Animal(string newName)
        {
            name = newName;
        }

        public void Feed()
        {
            Console.WriteLine("{0} has been fed.", name);
        }
    }
}