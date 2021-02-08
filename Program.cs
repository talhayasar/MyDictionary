using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary <int,string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1,"talha");//adding element to dictionary, key is 1 value is talha
            myDictionary.Add(2, "yasar");
            foreach (var name in myDictionary.Items)//printing the value of the dictionary
            {
                Console.WriteLine(name);
            }
        }
    }
}
