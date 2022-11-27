using System;
using System.Collections.Generic;
using System.Text;

class Chicken
{
    private string? name;
    private int age;

    public Chicken(int age)
    {
        this.Age = age;
    }

    public Chicken(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string? Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
}
