using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people.Add(new Person("super", 33));
            people.Add(new Person("tom", 18));
            people.Add(new Person("coco", 60));
            people.Add(new Person("fufu", 60));
            people.Add(new Person("jack", 33));

            foreach (DictionaryEntry entry in people)
            {
                Console.WriteLine("{0} {1}",
                    ((Person)entry.Value).Name, ((Person)entry.Value).Age);
            }

            Console.WriteLine("-------");

            Person[] persons = people.GetOldest();

            foreach (Person person in persons)
            {
                Console.WriteLine("{0} {1}",
                    person.Name, person.Age);
            }

            foreach (int age in people.Ages)
            {
                Console.WriteLine("{0}", age);
            }
            Console.ReadKey();
        }
    }
}
