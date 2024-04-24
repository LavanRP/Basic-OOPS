using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem
{
    /// <summary>
    /// Branch is a public enum which has following value {Eymard, Karuna, Madhura}<see cref="EmployeeDetails"/>
    /// </summary>
    public enum Branch{Eymard, Karuna, Madhura}
    /// <summary>
    /// EmployeeDetails class is used to hold the information of employees<see cref="EmployeeDetails"/>
    /// </summary>
    public class EmployeeDetails 
    {
        /// <summary>
        /// EmployeeID is used to store and get employees ID<see cref="EmployeeDetails"/>
        /// </summary>
        public string EmployeeID {get;set;}
        /// <summary>
        /// FullName is used to store and get employees FullName<see cref="EmployeeDetails"/>
        /// </summary>
        public string FullName {get;set;}
        /// <summary>
        /// DOB is used to store and get employees DOB<see cref="EmployeeDetails"/>
        /// </summary>
        public DateTime DOB {get;set;}
        /// <summary>
        /// MobileNumber is used to store and get employees MobileNumber<see cref="EmployeeDetails"/>
        /// </summary>
        public string MobileNumber {get;set;}
        /// <summary>
        /// Gender is used to store and get employees Gender<see cref="EmployeeDetails"/>
        /// </summary>
        public string Gender {get;set;}
        /// <summary>
        /// Branch is used to store and get employees Branch<see cref="EmployeeDetails"/>
        /// </summary>
        public Branch Branch {get;set;}
        /// <summary>
        /// Team is used to store and get employees Team<see cref="EmployeeDetails"/>
        /// </summary>
        public string Team {get;set;}
    }
}