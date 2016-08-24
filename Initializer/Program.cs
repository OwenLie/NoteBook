using System;

internal class Program
{
    public static void Main()
    {
        var classroom = new Classroom
        {
            //Students = { "Owen", "Vincent", "Lynn" }
            Students = { new Student { Name = "Owen", Age = 23 },
                         new Student { Name = "Vincent", Age = 22 },
                         new Student { Name = "Lynn", Age = 23 }}
        };

        foreach(var student in classroom.Students)
            Console.WriteLine(student);
    }
}