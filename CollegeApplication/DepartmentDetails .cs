using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeApplication
{
    /// <summary>
    /// Class DepartmentDetails used to create instance for Department <see cref="DepartmentDetails" />
    /// </summary> 
    public class DepartmentDetails 
    {
        /// <summary>
        /// DepartmentId Properties used to hold a student's DepartmentId of instance of <see cref="DepartmentDetails"/>
        /// </summary>
        public string DepartmentId{get;set;}
        /// <summary>
        /// DepartmentId Properties used to hold a student's DepartmentName of instance of <see cref="DepartmentDetails"/>
        /// </summary>
        public string DepartmentName{get;set;}
        /// <summary>
        /// NumberOfSeats Properties used to hold a department's NumberOfSeats of instance of <see cref="DepartmentDetails"/>
        /// </summary>
        public int NumberOfSeats{get;set;}
    }
}