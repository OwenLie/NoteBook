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
            var employees = new List<Employee>();
            employees.Add(new Employee { Name = "Owen", Id = 1000 });
            employees.Add(new Employee { Name = "Vincent", Id = 1001 });
            employees.Add(new Employee { Name = "Lynn", Id = 1002 });
            employees.Add(new Employee { Name = "Ricy", Id = 1003 });

            //var employees = new List<string>();
            //employees.Add("Owen");
            //employees.Add("Vincent");
            //employees.Add("Lynn");
            //employees.Add("Ricy");

            // output all the elements
            foreach (var employee in employees)
                Console.WriteLine(employee);

            //string owen = "Owen";
            //if (employees.Contains(owen))
            //    Console.WriteLine("Owen exists");

            // check for a certain value
            // when calling Contains(), if Employee implements IEquatable<Employee>,
            // it calls IEquatable.Equals, otherwise, it calls Object.Equals
            if (employees.Contains(new Employee { Name = "Owen", Id = 1000 }))
                Console.WriteLine("Owen contained");
            else
                Console.WriteLine("Owen not exists");

            // since List based on array, we can insert item at a certain position
            employees.Insert(2, new Employee { Name = "Alice", Id = 1004 });

            // get a certain item, index from 0
            Console.WriteLine(employees[2]);

            // remove an item, since it calls IEquatable.Equals, Alice will
            // be removed although Michael is indicated
            // if the list contains two elements that has same Id,
            // then the smaller indexed one will be removed
            employees.Remove(new Employee { Name = "Michael", Id = 1004 });

            Console.ReadLine();
        }
    }
}
