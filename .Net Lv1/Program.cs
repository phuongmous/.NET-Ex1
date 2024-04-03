using System;
//Exercise 1:
//class Person
//{
//    public void Greet()
//    {
//        Console.WriteLine("Hello!");
//    }
//    protected int Age { get; set; }
//    public void SetAge(int age)
//    {
//        Age = age;
//    }
//}

//class Student: Person
//{
//    public void Study()
//    {
//        Console.WriteLine("I'm studying");
//    }
//    public void ShowAge()
//    {
//        Console.WriteLine($"My age is: {Age} years old");
//    }
//}

//class Teacher: Person
//{
//    public void Explain()
//    {
//        Console.WriteLine("I'm explaining");
//    }
//}

//class StudentProfessorTest
//{
//    static void Main(string[] args)
//    {
//        Person person = new Person();
//        person.Greet();

//        Student student = new Student();
//        student.SetAge(20);
//        student.Greet();
//        student.ShowAge();

//        Teacher teacher = new Teacher();
//        teacher.SetAge(24);
//        teacher.Greet();
//        teacher.Explain();
//    }
//}

//Exercise 2:
//abstract class Animal
//{
//    protected string Name { get; set; } = "";
//    public void SetName(string name)
//    {
//        Name = name;
//    }
//    public string GetName()
//    {
//        return Name;
//    }
//    public abstract void Eat();
//}

//class Dog: Animal
//{
//    public override void Eat()
//    {
//        Console.WriteLine($"{Name} is eating");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter the name of the dog: ");
//        string dogName = Console.ReadLine();
//        Dog dog = new Dog();
//        dog.SetName(dogName);
//        Console.WriteLine($"Dog's name is: {dog.GetName()}");
//        dog.Eat();
//    }

//}

//Exercise 3:
interface IVehicle
{
    void Drive();
    bool Refuel(int amount);
}

class Car
{
    private int gasolineLevel;
    public Car(int startingGasoline)
    {
        gasolineLevel = startingGasoline;
    }
    public void Drive()
    {
        if (gasolineLevel > 0)
        {
            Console.WriteLine("The car is driving");
        }
        else
        {
            Console.WriteLine("Cannot drive. Gasoline level is 0");
        }
    }
    public bool Refuel(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount of gasoline to refuel!");
            return false;
        }
        gasolineLevel += amount;
        Console.WriteLine($"Refuel {amount} units of gasoline. The current gasoline level is {gasolineLevel}");
        return true;
    }
}

class Program1
{
    static void Main(string[] args)
    {
        Car car = new Car(0);
        Console.Write("Enter an amount of gasoline to refuel: ");
        int amountToRefuel = Convert.ToInt32(Console.ReadLine());
        car.Refuel(amountToRefuel);
        car.Drive();
    }

}