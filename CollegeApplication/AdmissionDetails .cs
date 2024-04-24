using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeApplication
{
    /// <summary>
    /// AdmissionStatus is a public enum which has following value{Select, Booked, Cancelled} <see cref="AdmissionDetails"/>
    /// </summary> 
    public enum AdmissionStatus{Select, Booked, Cancelled} 
    /// <summary>
    /// Class AdmissionDetails used to create instance for Admission <see cref="StudentDetails" />
    /// </summary> 
    public class AdmissionDetails 
    {
        /// <summary>
        /// AdmissionId Properties used to hold a student's AdmissionId of instance of <see cref="AdmissionDetails"/>
        /// </summary>
        public string AdmissionId{get;set;}
         /// <summary>
        /// StudentId Properties used to hold a student's Id of instance of <see cref="AdmissionDetails"/>
        /// </summary>
        public string StudentId{get;set;}
         /// <summary>
        /// DepartmentId Properties used to hold a student's DepartmentId of instance of <see cref="AdmissionDetails"/>
        /// </summary>
        public string DepartmentId{get;set;}
         /// <summary>
        /// AdmissionDate Properties used to hold a student's AdmissionDate of instance of <see cref="AdmissionDetails"/>
        /// </summary>
        public DateTime AdmissionDate{get;set;}
        /// <summary>
        /// AdmissionStatus Properties used to hold a student's AdmissionStatus of instance of <see cref="AdmissionDetails"/>
        /// </summary>
        public AdmissionStatus AdmissionStatus{get;set;}

    }
}