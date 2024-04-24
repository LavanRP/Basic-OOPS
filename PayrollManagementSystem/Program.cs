using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
namespace PayrollManagementSystem;

class Program
{
    public static void Main(string[] args)
    {
        List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
        List<AttendanceDetails> attendanceDetails = new List<AttendanceDetails>();

        Console.WriteLine("-----Welcome to Syncfusion SoftWare Private Limited-----");
        Console.WriteLine("***************************************************");
        int mainOption;
        int emNum = 3001;
        string emStr = "SF";
        int atNum = 1001;
        string atStr = "AID";
        do
        {
            Console.WriteLine("1. Employee Registration\n2. Employee Login\n3. Exit");
            mainOption = int.Parse(Console.ReadLine());
            switch (mainOption)
            {
                case 1:
                    {
                        //Employee Registaition
                        EmployeeDetails employee = new EmployeeDetails();
                        Console.WriteLine("Enter your full name");
                        employee.FullName = Console.ReadLine();
                        //date of birth
                        Console.WriteLine("Enter your Date of Birth->dd/MM/yyyy");
                        DateTime date;
                        bool ans;
                        do
                        {
                            ans = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date);
                            if (ans)
                            {
                                employee.DOB = date;
                            }
                            else
                            {
                                Console.WriteLine("please check the date formate and re-enter the date.");
                            }
                        } while (!ans);
                        Console.WriteLine("Enter your Gender");
                        employee.Gender=Console.ReadLine();
                        Console.WriteLine("Enter your Mobile Number");
                        employee.MobileNumber = Console.ReadLine();
                        //branch
                        bool temp;
                        Console.WriteLine("Enter your branch : Eymard, Karuna, Madhura");
                        Branch branch;
                        do
                        {
                            temp = Enum.TryParse<Branch>(Console.ReadLine(), true, out branch);
                            if (temp)
                            {
                                employee.Branch = branch;
                            }
                            else
                            {
                                Console.WriteLine("please check the branch formate and re-enter your gender.");
                            }
                        } while (!temp);
                        Console.WriteLine("Enter your Team name");
                        employee.Team = Console.ReadLine();
                        employee.EmployeeID = emStr + emNum;
                        emNum++;
                        Console.WriteLine("Employee added successfully your id is: " + employee.EmployeeID);
                        employeeDetails.Add(employee);
                        break;
                    }
                case 2:
                    {
                        //Employee Login
                        Console.WriteLine("Enter your employee id");
                        string empID = Console.ReadLine();
                        foreach (EmployeeDetails emp in employeeDetails)
                        {
                            if (emp.EmployeeID.Equals(empID))
                            {

                                int subOption;
                                do
                                {
                                    Console.WriteLine("1. Add Attendance\n2. Display Details\n3. Calculate Salary\n4. Exit");
                                    subOption = int.Parse(Console.ReadLine());
                                    switch (subOption)
                                    {
                                        case 1:
                                            {
                                                //Add Attedence
                                                AttendanceDetails attendance = new AttendanceDetails();
                                                Console.WriteLine("Do you want to check in? ->yes or no");
                                                string str1 = "";
                                                do
                                                {
                                                    str1 = Console.ReadLine();
                                                    if (str1.Equals("yes"))
                                                    {
                                                        Console.WriteLine("Enter date in the following formate-> dd/HH/yyyy");
                                                        bool a;
                                                        DateTime date1;
                                                        do
                                                        {
                                                            a = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date1);
                                                            if (a)
                                                            {
                                                                attendance.Date = date1;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("please check the date formate and re-enter the date.");
                                                            }
                                                        } while (!a);
                                                        //check in
                                                        Console.WriteLine("Enter the Time of check-in in the following formate-> hh:mm tt");
                                                        DateTime checkin;
                                                        bool res1;
                                                        do
                                                        {
                                                            res1 = DateTime.TryParseExact(Console.ReadLine(), "hh:mm tt", null, System.Globalization.DateTimeStyles.None, out checkin);
                                                            if (res1)
                                                            {
                                                                attendance.AttendanceID = atStr + atNum;
                                                                atNum++;
                                                                attendance.EmployeeID = emp.EmployeeID;
                                                                attendance.CheckInTime = checkin;
                                                                Console.WriteLine("Do you Want to check-out? ->yes or no");
                                                                string str2 = "";
                                                                do
                                                                {
                                                                    str2 = Console.ReadLine();
                                                                    if (str2.Equals("yes"))
                                                                    {
                                                                        //check out
                                                                        Console.WriteLine("Enter the Date and Time of check-out in the following formate-> hh:mm tt");
                                                                        DateTime checkout;
                                                                        bool res2;
                                                                        do
                                                                        {
                                                                            res2 = DateTime.TryParseExact(Console.ReadLine(), "hh:mm tt", null, System.Globalization.DateTimeStyles.None, out checkout);
                                                                            if (res2)
                                                                            {
                                                                                attendance.CheckOutTime = checkout;
                                                                                attendance.HoursWorked = attendance.CheckOutTime - attendance.CheckInTime;
                                                                                attendanceDetails.Add(attendance);
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("please check the date formate and re-enter the date.");
                                                                            }
                                                                        } while (!res2);
                                                                        break;
                                                                    }
                                                                    else if (!(str2.Equals("no")))
                                                                    {
                                                                        Console.WriteLine("Invalid input. Only yes Or no");
                                                                    }
                                                                } while (!(str2.Equals("no")));
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("please check the date formate and re-enter the date.");
                                                            }
                                                        } while (!res1);
                                                        break;
                                                    }
                                                    else if (!(str1.Equals("no")))
                                                    {
                                                        Console.WriteLine("Invalid input. only yes Or no");
                                                    }
                                                } while (!(str1.Equals("no")));
                                                int j = int.Parse(attendance.HoursWorked.ToString("hh"))-1;
                                                Console.WriteLine("Check-in and Checkout Successful and today you have worked " + j + " Hours");
                                                break;
                                            }
                                        case 2:
                                            {
                                                //Display Details
                                                Console.WriteLine("your Name : " + emp.FullName);
                                                Console.WriteLine("your DOB : " + emp.DOB.ToString("dd/MM/yyyy"));
                                                Console.WriteLine("your Mobile no : " + emp.MobileNumber);
                                                Console.WriteLine("your gender : " + emp.Gender);
                                                Console.WriteLine("your Branch : " + emp.Branch);
                                                Console.WriteLine("your Team : " + emp.Team);
                                                break;
                                            }
                                        case 3:
                                            {
                                                //Calculate Salary
                                                Console.WriteLine("AttendanceID\tEmployeeID\tDate\t\tCheckInTime\tCheckOutTime\tHoursWorked");
                                                foreach (AttendanceDetails att in attendanceDetails)
                                                {
                                                    if (att.EmployeeID == emp.EmployeeID)
                                                    {
                                                        int n = int.Parse(att.HoursWorked.ToString("hh"))-1;
                                                        Console.WriteLine(att.AttendanceID + "\t\t" + att.EmployeeID + "\t\t" + att.Date.ToString("dd/MM/yyyy") + "\t" + att.CheckInTime.ToString("hh:mm tt") + "\t" + att.CheckOutTime.ToString("hh:mm tt") + "\t" + n);
                                                        double day = n / 8;
                                                        double sal = day * 500;
                                                        Console.WriteLine("Total salary : " + sal);
                                                    }
                                                }
                                                break;
                                            }
                                        case 4:
                                            {
                                                //exit
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Enter valid number");
                                                break;
                                            }
                                    }
                                } while (!(subOption == 4));
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        //exit
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a valid number");
                        break;
                    }
            }
        } while (!(mainOption == 3));
    }
}
