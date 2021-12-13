using GenericClassPracticeExercise.Models;
using System;

namespace GenericClassPracticeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DataList<string> strs = new DataList<string>();

            strs.Add("Elmin");
            strs.Add("Vusal");
            strs.Add("Musa");

            strs.GetAll();

            DataList<int> nums = new DataList<int>();
            nums.Add(4);
            nums.Add(7);
            nums.Add(9);

            nums.GetAll();
                       
        }
    }
}
