using System;
class Person
{
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }
    protected int Age { get; set; }
    public void SetAge(int age)
    {
        Age = age;
    }
}

class Student: Person
{
    public void Study()
    {
        Console.WriteLine("I'm studying");
    }
    public void ShowAge()
    {
        Console.WriteLine($"My age is: {Age} years old");
    }
}

class Teacher: Person
{
    public void Explain()
    {
        Console.WriteLine("I'm explaining");
    }
}

class StudentProfessorTest
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Greet();

        Student student = new Student();
        student.SetAge(20);
        student.Greet();
        student.ShowAge();

        Teacher teacher = new Teacher();
        teacher.SetAge(24);
        teacher.Greet();
        teacher.Explain();
    }
}