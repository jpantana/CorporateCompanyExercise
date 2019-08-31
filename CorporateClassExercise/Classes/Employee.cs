using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClassExercise.Classes
{
    class Employee
    {
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string firstname, string lastname, string jobTitle, DateTime startDate)
        {
            EmpFirstName = firstname;
            EmpLastName = lastname;
            JobTitle = jobTitle;
            StartDate = startDate;
        }
    }
}
