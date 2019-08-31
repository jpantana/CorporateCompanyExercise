using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClassExercise.Classes
{
    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
            The constructor will set the value of the public properties
        */
        public Company(string companyName, DateTime companyGoesLiveDate)
        {
            Name = companyName;
            CreatedOn = companyGoesLiveDate;
        }


        // Create a property for holding a list of current employees
        List<Employee> CurrentEmployees = new List<Employee>();

        public void showCurrentEmployees()
        {
            for (var i = 0; i < CurrentEmployees.Count; i++)
            {
                Console.Write(CurrentEmployees[i].EmpFirstName + " ,");
            }
        }

    // Create a method that allows external code to add an employee
        public void AddEmployee(string firstname, string lastname, string jobTitle)
            {
                var makeEmployee = new Employee(firstname, lastname, jobTitle, DateTime.Now);
                CurrentEmployees.Add(makeEmployee);
            }

        // Create a method that allows external code to remove an employee
        public void RemoveEmployee(int indexToRemove)
        {
            CurrentEmployees.Remove(CurrentEmployees[indexToRemove]);
        }
    }
}
