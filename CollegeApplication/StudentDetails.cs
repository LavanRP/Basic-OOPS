using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace CollegeApplication
{
    /// <summary>
    /// DataType gender used to select a instance of <see cref="StudentDetails" /> Gender Information
   /// </summary> 
    public enum Gender{Select, Male, Female, Transgender}
    /// <summary>
    /// Class StudentDetails used to create instance for student <see cref="StudentDetails" />
    /// </summary> 
    public class StudentDetails
    {
        /// <summary>
        /// StudentName Properties used to hold a student's name of instance of <see cref="StudentDetails"/>
        /// </summary>
        public string StudentName{get;set;}
        /// <summary>
        /// StudentID Properties used to hold a student's ID of instance of <see cref="StudentDetails"/>
        /// </summary>
        public string StudentId{get;set;}
        /// <summary>
        /// FatherName Properties used to hold a student's FatherName of instance of <see cref="StudentDetails"/>
        /// </summary>
        public string FatherName{get;set;}
        /// <summary>
        /// DOB Properties used to hold a student's Date of birth of instance of <see cref="StudentDetails"/>
        /// </summary>
        public DateTime DOB{get;set;}
        /// <summary>
        /// Gender Properties used to hold a student's Gender of instance of <see cref="StudentDetails"/>
        /// </summary>
        public Gender Gender{get;set;}
        /// <summary>
        /// Physics Properties used to hold a student's Physics mark of instance of <see cref="StudentDetails"/>
        /// </summary>
        public int Physics{set;get;}
         /// <summary>
        /// Chemistry Properties used to hold a student's Chemistry mark of instance of <see cref="StudentDetails"/>
        /// </summary>
        public int Chemistry{set;get;}
         /// <summary>
        /// Maths Properties used to hold a student's Maths mark of instance of <see cref="StudentDetails"/>
        /// </summary>
        public int Maths{set;get;}
         /// <summary>
        /// Average Properties used to hold a student's Average mark of instance of <see cref="StudentDetails"/>
        /// </summary>
        public double Average{set;get;}
        /// <summary>
        /// CheckEligibility methods takes 3 int as argument and calculate average.return a boolean value.Store the value in Average property <see cref="StudentDetails" />
        /// </summary>
        /// <param name="phisics">"a" used to store value from Physics property</param>
        /// <param name="chemistry">"b" used to store value from Chemistry property</param>
        /// <param name="maths">"c" used to store value from Maths property</param>
        /// <returns>returns a boolean value true if average is >=75 else returns false</returns> <summary>
        public bool CheckEligibility(int phisics,int chemistry,int maths)
        {
            double average=(phisics+chemistry+maths)/3;
            Average=average;
            if(average>=75.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Constructor StudentDetails used to initialize defualt values to its properties.
        /// </summary>
        public StudentDetails()
        {

        }
        /// <summary>
        /// Constructors StudentDetails used to initialize parameter values to its properties.
        /// </summary>
        /// <param name="name">name used to assign its value to StudentName property</param>
         public StudentDetails(string name)
        {
            StudentName=name;
        }
    }
}