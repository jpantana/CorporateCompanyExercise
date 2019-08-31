using System;
using CorporateClassExercise.Classes;

namespace CorporateClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyName = "Big Bernie's House Of Tuna";
            var coCreatedOn = "7/4/2010";
            DateTime companyGoesLive = Convert.ToDateTime(coCreatedOn);

            Console.WriteLine("What's your first name?");
            var firstNameInput = Console.ReadLine();

            Console.WriteLine("What's your last name?");
            var lastNameInput = Console.ReadLine();

            Console.WriteLine("What do you want your job title to be?");
            var jobTitle = Console.ReadLine();

            var myCompany = new Company(companyName, companyGoesLive);
            myCompany.AddEmployee(firstNameInput, lastNameInput, jobTitle);

            Console.WriteLine("What's your first name?");
            var firstNameInput2 = Console.ReadLine();

            Console.WriteLine("What's your last name?");
            var lastNameInput2 = Console.ReadLine();

            Console.WriteLine("What do you want your job title to be?");
            var jobTitle2 = Console.ReadLine();

            myCompany.AddEmployee(firstNameInput2, lastNameInput2, jobTitle2);

            Console.WriteLine("What's your first name?");
            var firstNameInput3 = Console.ReadLine();

            Console.WriteLine("What's your last name?");
            var lastNameInput3 = Console.ReadLine();

            Console.WriteLine("What do you want your job title to be?");
            var jobTitle3 = Console.ReadLine();

            myCompany.AddEmployee(firstNameInput3, lastNameInput3, jobTitle3);

            myCompany.showCurrentEmployees();
            Console.WriteLine("Wanna remove an employee who no longer works for this sweet company? What number in the list is it? (or press n)");
            var numRespEmpToRemove = Console.ReadLine();

            if (numRespEmpToRemove == "1")
            {
                myCompany.RemoveEmployee(0);
                myCompany.showCurrentEmployees();
            }
            if (numRespEmpToRemove == "2")
            {
                myCompany.RemoveEmployee(1);
                myCompany.showCurrentEmployees();
            }
            if (numRespEmpToRemove == "3")
            {
                myCompany.RemoveEmployee(2);
                myCompany.showCurrentEmployees();
            }
            else
            {

            }
        }
    }
}
