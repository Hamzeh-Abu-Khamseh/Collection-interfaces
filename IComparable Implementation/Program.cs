using System;
using System.Collections.Generic;



public class Person :IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int CompareTo(Person other)
    {
        if (other == null) return 1;
        return Age.CompareTo(other.Age);
    }
    public Person(string name,int age)
    {
        Name = name;
        Age = age;
    }
    public override string ToString()
    {
        return $"{Name}, {Age} years old";
    }
}
public class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person("Alice", 30),
            new Person("Bob", 25),
            new Person("Charlie", 35)
        };
        people.Sort(); // Sorts by Age due to IComparable implementation
        Console.WriteLine("Sorted People by Age:");
        foreach (var person in people)
        {
            Console.WriteLine(person.ToString());
        }
        Console.ReadKey();
    }
}