using System;

// class 5
internal class ClassFive
{
    // subscribe the event
    public ClassFive(TimeManager m)
    {
        // when event ClassBegins is triggered, method StartClass
        // will be called.
        m.ClassBegins += StartClass;
    }

    // This method is called whenever ClassBegins event is triggered
    // method signature should be the same as EventHandler
    private void StartClass(Object sender, ClassBeginsEventArgs e)
    {
        Console.WriteLine(e.Teacher + "'s " + e.Subject + " class begins");
    }
}