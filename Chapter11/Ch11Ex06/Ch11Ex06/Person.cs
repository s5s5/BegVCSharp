namespace Ch11Ex06
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
            : this("xixi", 8)
        {
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //public static bool operator ==(Person person1, Person person2)
        //{
        //    return person1.Age == person2.Age;
        //}

        //public static bool operator !=(Person person1, Person person2)
        //{
        //    return !(person1 == person2);
        //}

        //public override bool Equals(object obj)
        //{
        //    return this == (Person)obj;
        //}

        //public override int GetHashCode()
        //{
        //    return (int)Age;
        //}

        public static bool operator >(Person person1, Person person2)
        {
            return person1.Age > person2.Age;
        }

        public static bool operator <(Person person1, Person person2)
        {
            return person1.Age < person2.Age;
        }

        public static bool operator >=(Person person1, Person person2)
        {
            return !(person1 < person2);
        }

        public static bool operator <=(Person person1, Person person2)
        {
            return !(person1 > person2);
        }
    }
}