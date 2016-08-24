using System;
// define an EventArgs class to deliver args for the event
internal class ClassBeginsEventArgs : EventArgs
{
    private readonly string teacher, subject;

    public ClassBeginsEventArgs(string teacher, string subject)
    {
        this.teacher = teacher;
        this.subject = subject;
    }

    public string Teacher { get { return this.teacher; } }
    public string Subject { get { return this.subject; } }
}