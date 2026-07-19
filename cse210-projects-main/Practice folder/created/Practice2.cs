using System;

class Person
{
    public string _givenName;
    public string _familyName;
    public string _courseOffered;

    public void ShowWesternName()
    {
        Console.WriteLine($"Weatern Name: {_givenName} {_familyName}");
    }

    public void ShowEasternName ()
    {
        Console.WriteLine($"Eastern Name: {_familyName} {_givenName}");
    }

    public void ShowCourseOffered ()
    {
        Console.WriteLine($"Course Offered: {_courseOffered} ");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person._givenName = "John";
        person._familyName = "Jason";
        person._courseOffered = "CSE-210";

        person.ShowWesternName ();
        person.ShowEasternName ();
        person.ShowCourseOffered ();
    }
}