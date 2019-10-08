using System;

namespace Zavd_3
{
 class Person
    { 
    private string name;
    private int age;
    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }
    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            age = value;
        }
    }
}

    class Family : Person
    {

    }
    
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
