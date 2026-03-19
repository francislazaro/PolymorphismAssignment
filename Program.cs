using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an object using polymorphism
        // The object is of type IQuittable but holds an Employee instance
        IQuittable employee = new Employee()
        {
            FirstName = "John",
            LastName = "Smith",
            Id = 1
        };

        // Call the Quit() method using the interface reference
        employee.Quit();

        // Keeps the console window open
        Console.ReadLine();
    }
}
