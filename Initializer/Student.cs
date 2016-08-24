using System;

internal class Student
{
    private string name;
    private int age;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if(value < 0)
                throw new ArgumentOutOfRangeException("value", value.ToString(),
                    "The value must be greater than or equal to 0");
            else
                this.age = value;
        }
    }

    public override string ToString()
    {
        return this.name + " is " + this.age;
    }
}