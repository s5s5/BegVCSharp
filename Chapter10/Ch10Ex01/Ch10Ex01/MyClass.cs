﻿using System;

namespace Ch10Ex01
{
    public class MyClass
    {
        public readonly string Name;
        private int intVal;
        private string myString;

        public string MyString
        {
            get { return myString; }
            set { myString = value; }
        }

        public int Val
        {
            get { return intVal; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    intVal = value;
                }
                else
                {
                    throw (new ArgumentOutOfRangeException("Val", value,
                           "Val must be assigned a value between 0 and 10."));
                }
            }
        }

        public int MyInt
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int MyIntProp { get; private set; }

        public override string ToString()
        {
            return "Name: " + Name + "\nVal: " + Val;
        }

        public double MyMethod(double paramX, double paramY)
        {
            throw new System.NotImplementedException();
        }

        private MyClass()
            : this("Default Name")
        {

        }

        public MyClass(string newName)
        {
            Name = newName;
            intVal = 0;
        }
    }
}