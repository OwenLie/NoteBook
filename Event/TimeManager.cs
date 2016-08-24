using System;

// define a time manager class to inform that class begins
internal class TimeManager
{
    // class begins event
    public event EventHandler<ClassBeginsEventArgs> ClassBegins;

    // trigger the event
    public static void Main()
    {
        // prepare the class info
        var e = new ClassBeginsEventArgs("Owen", "English");

        // subscribe an event
        var m = new TimeManager();
        var class5 = new ClassFive(m);

        // ring bell
        m.RingBell(e);
    }

    // ring bell
    private void RingBell(ClassBeginsEventArgs e)
    {
        // trigger the event
        ClassBegins(this, e);
    }
}