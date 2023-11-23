using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Employee
{
    protected string name;
    protected int age;
    protected double salary;

    
    public Employee(string name, int age, double salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;
    }

    
    public virtual void GetInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");
    }

   
    public virtual double CalculateAnnualSalary()
    {
        return salary * 12;
    }
}


class Manager : Employee
{
    protected double bonus;

    
    public Manager(string name, int age, double salary, double bonus) : base(name, age, salary)
    {
        this.bonus = bonus;
    }

    
    public override double CalculateAnnualSalary()
    {
        return base.CalculateAnnualSalary() + bonus;
    }
}


class Developer : Employee
{
    protected int linesOfCodePerDay;

   
    public Developer(string name, int age, double salary, int linesOfCodePerDay) : base(name, age, salary)
    {
        this.linesOfCodePerDay = linesOfCodePerDay;
    }

    
    public override double CalculateAnnualSalary()
    {
        
        return base.CalculateAnnualSalary() + (linesOfCodePerDay * 0.1 * salary); 
    }
}

class Program
{
    static void Main()
    {
        
        Manager manager = new Manager("John Manager", 35, 60000, 5000);

       
        Developer developer = new Developer("Alice Developer", 28, 70000, 100);

        
        manager.GetInfo();
        Console.WriteLine($"Manager's Annual Salary: {manager.CalculateAnnualSalary()}");

        Console.WriteLine();

        developer.GetInfo();
        Console.WriteLine($"Developer's Annual Salary: {developer.CalculateAnnualSalary()}");
    }
}
