using System;
using System.Collections.Generic;
using System.Text;

namespace SortingByUsingOperator.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(int age, string name, string surname)
        {
            age = Age;

            name = Name;

            surname = Surname;
           
        }

    
        public static bool operator > (Person person, Person person1)
        {
            return person.Age > person.Age;
        }
        public static bool operator < (Person person, Person person1)
        {
            return person.Age < person.Age;
        }

    }
}
