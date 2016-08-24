using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main()
        {
            // create a dictionary
            var employees = new Dictionary<string, int>();

            // add element
            employees.Add("Owen", 23);
            employees.Add("Vincent", 22);
            employees.Add("Lynn", 22);
            employees.Add("Ricy", 21);

            // if key exists, throw exception
            try
            {
                employees.Add("Owen", 21);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with key 'Owen' exists");
            }

            // get value through key
            Console.WriteLine("Owen is " + employees["Owen"] + " years old");

            // set value through key
            employees["Owen"] = 20;

            // add element through indexer
            employees["Alice"] = 25;
            Console.WriteLine("Alice is " + employees["Alice"] + " years old");

            // if key not exist, throw exception
            try
            {
                Console.WriteLine("Michael is " + employees["Michael"] + " years old");
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("No key 'Michael' found");
            }

            // keys always not exist, TryGetValue() is more efficient
            int age = -1;
            if (employees.TryGetValue("Michael", out age))
            {
                Console.WriteLine("Michael is " + employees["Michael"] + " years old");
            }
            else
            {
                Console.WriteLine("No key 'Michael' found");
            }

            // use foreach expression to iterate the diction
            Console.WriteLine();
            foreach(KeyValuePair<string, int> kvp in employees)
                Console.WriteLine(kvp.Key + " is " + kvp.Value + " years old");

            // get all keys
            var keys = employees.Keys;
            foreach (string key in keys)
                Console.WriteLine(key);

            // get all values
            var ages = employees.Values;
            foreach (int ageValue in ages)
                Console.WriteLine(ageValue);

            // remove a pair through key
            employees.Remove("Alice");
            if (!employees.ContainsKey("Alice"))
                Console.WriteLine("Alice is removed");

            Console.ReadLine();
        }
    }
}
