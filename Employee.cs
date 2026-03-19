using System;

// Employee class implements the IQuittable interface
public class Employee : IQuittable
{
    // Property for the employee's first name
    public string FirstName { get; set; }

    // Property for the employee's last name
    public string LastName { get; set; }

    // Property for the employee's ID
    public int Id { get; set; }

    // Implementation of the Quit() method from the interface
    public void Quit()
    {
        // Display a message when the employee quits
        Console.WriteLine(FirstName + " " + LastName + " has quit the company.");
    }
}
