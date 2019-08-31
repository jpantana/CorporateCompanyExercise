using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClassExercise.Classes
{
    class EmployeeData
    {
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public string JobTitle { get; set; }
        public string StartDate { get; set; }

        public EmployeeData(string firstname, string lastname, string jobTitle, string startDate)
        {
            EmpFirstName = firstname;
            EmpFirstName = lastname;
            JobTitle = jobTitle;
            StartDate = startDate;
        }
    }
}
