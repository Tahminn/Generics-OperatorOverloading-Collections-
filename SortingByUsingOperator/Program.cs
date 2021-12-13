using SortingByUsingOperator.Models;
using System;

namespace SortingByUsingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person(23, "Haziyev", "Xalid");
          
            Person person1 = new Person(21, "Behbudov", "Su");

            Person[] persons = { person, person1 };
                      
            Console.WriteLine(person1 > person);

        }
    }
}
