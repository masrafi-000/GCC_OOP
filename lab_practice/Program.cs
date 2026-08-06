using System;
using System.ComponentModel;
using System.Globalization;
using System.Transactions;

class Person
{
    protected string Name;
    protected int Age;

    public void InputPersonInfo()
    {
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();
        
        Console.Write("Enter Age: ");
        Age = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayPersonInfo()
    {
        Console.WriteLine("Name      : "+Name);
        Console.WriteLine("Age      : "+Age);
    }
}


class Student : Person
{
    private string StudentID, Department;
    private double CGPA;

    public void InputStudentInfo()
    {
        InputPersonInfo();

        Console.Write("Enter Student ID: ");
        StudentID = Console.ReadLine();

        Console.Write("Enter Department: ");
        Department = Console.ReadLine();

        Console.Write("Enter CGPA: ");
        CGPA = Convert.ToDouble(Console.ReadLine());
    }

    public string AcademicStatus()
    {
        if(CGPA >= 3.75)
        {
            return "Excellent";
        } else if(CGPA >= 3.00)
        {
            return "GOOD";
        } else if(CGPA >= 2.00)
        {
            return "Satosfactory";
        } else
        {
            return "Probation";
        }
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine("\n===== Student Information =====");
        DisplayPersonInfo();
        Console.WriteLine("Student ID : " + StudentID);
        Console.WriteLine("Department : " + Department);
        Console.WriteLine("CGPA       : " + CGPA);
        Console.WriteLine("Status     : " + AcademicStatus());
    }
}


class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();

        s1.InputStudentInfo();
        s1.DisplayStudentInfo();

        Console.ReadKey();
    }
}