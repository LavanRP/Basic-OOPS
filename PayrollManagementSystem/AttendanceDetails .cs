using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem
{
    /// <summary>
    /// AttendanceDetails class is used to hold the information of employees Attendance Details<see cref="AttendanceDetails"/>
    /// </summary>
    public class AttendanceDetails
    {
        /// <summary>
        /// AttendanceID is used to store and get employees AttendanceID<see cref="AttendanceDetails"/>
        /// </summary>
        public string AttendanceID { get; set; }
        /// <summary>
        /// EmployeeID is used to store and get employees ID<see cref="AttendanceDetails"/>
        /// </summary>
        public string EmployeeID { get; set; }
        /// <summary>
        /// Date is used to store and get employees Date<see cref="AttendanceDetails"/>
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// CheckInTime is used to store and get employees CheckInTime<see cref="AttendanceDetails"/>
        /// </summary>
        public DateTime CheckInTime { get; set; }
        /// <summary>
        /// CheckOutTime is used to store and get employees CheckOutTime<see cref="AttendanceDetails"/>
        /// </summary>
        public DateTime CheckOutTime { get; set; }
        /// <summary>
        /// HoursWorked is used to store and get employees HoursWorked<see cref="AttendanceDetails"/>
        /// </summary>
        public TimeSpan HoursWorked { get; set; }
    }
}