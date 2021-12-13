using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassPracticeExercise.Models
{
    class DataList<T>
    {
        private T[] arr;
        public DataList()
        {
            arr = new T[0];
        }
        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public void Add(T data)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = data;
        }


    }
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
    }
  
}
