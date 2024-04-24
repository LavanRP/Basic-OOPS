using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayrollManagement
{
    public enum Gender{select,Male,Female}
    public enum Location{select,Madurai,Chennai}
    public class EmployeDetails
    {
        public string EmployeeName{get;set;}
        public Gender Gender{get;set;}
        public string EmployeeId{get;set;}
        public string Role{get;set;}
        public Location WorkLocation{get;set;}
        public string TeamName{get;set;}
        public DateTime DateOfJoine{get;set;}
        public int WorkingDay{get;set;}
        public int Leave{get;set;}
        public int Salary{get;set;}
        
        public void SalaryCalculation()
        {
            Salary=(WorkingDay-Leave)*500;
            Console.WriteLine("Your Salary :"+Salary);
        }
        
    }
}