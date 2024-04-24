using System;
using System.Collections.Generic;
namespace CollegeApplication;
class Program
{
    public static void Main(string[] args)
    {
        //adding Department details
        List<DepartmentDetails> departmentDetails = new List<DepartmentDetails>();
        DepartmentDetails department1 = new DepartmentDetails();
        department1.DepartmentId = "DID101";
        department1.DepartmentName = "EEE";
        department1.NumberOfSeats = 29;
        departmentDetails.Add(department1);

        DepartmentDetails department2 = new DepartmentDetails();
        department2.DepartmentId = "DID102";
        department2.DepartmentName = "CSE";
        department2.NumberOfSeats = 29;
        departmentDetails.Add(department2);

        DepartmentDetails department3 = new DepartmentDetails();
        department3.DepartmentId = "DID103";
        department3.DepartmentName = "MECH";
        department3.NumberOfSeats = 30;
        departmentDetails.Add(department3);

        DepartmentDetails department4 = new DepartmentDetails();
        department4.DepartmentId = "DID104";
        department4.DepartmentName = "ECE";
        department4.NumberOfSeats = 30;
        departmentDetails.Add(department4);

        List<AdmissionDetails> admissionDetails = new List<AdmissionDetails>();

        Console.WriteLine("");
        Console.WriteLine("-----Wellcome to Syncfusion College of Engineering and Technology-----");
        Console.WriteLine("**********************************************************************");
        int mainOption = 0;
        List<StudentDetails> studentDetails = new List<StudentDetails>();
        string stdId = "SF";
        int num = 3000;
        string admId = "AID";
        int num1 = 1001;
        do
        {
            Console.WriteLine("1. Student Registratio\n2. Student Login\n3. Department wise seat availability\n4. Exit");
            mainOption = int.Parse(Console.ReadLine());
            StudentDetails student = new StudentDetails();
            switch (mainOption)
            {
                case 1:
                    {
                        //Student Details
                        Console.WriteLine("Enter your name : ");
                        student.StudentName = Console.ReadLine();
                        Console.WriteLine("Enter your Father name : ");
                        student.FatherName = Console.ReadLine();
                        Console.WriteLine("Enter your Date Of Birth int the following form: ");
                        //date of birth
                        DateTime date;
                        bool ans;
                        do
                        {
                            ans = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date);
                            if (ans)
                            {
                                student.DOB = date;
                            }
                            else
                            {
                                Console.WriteLine("please check the date formate and re-enter the date.");
                            }
                        } while (!ans);
                        //gender
                        bool temp;
                        Console.WriteLine("Enter the gender : Male, Female, Transgender");
                        Gender gender;
                        do
                        {
                            temp = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
                            if (temp)
                            {
                                student.Gender = gender;
                            }
                            else
                            {
                                Console.WriteLine("please check the gender formate and re-enter your gender.");
                            }
                        } while (!temp);

                        Console.WriteLine("Enter your Physics marks : ");
                        student.Physics = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Chemistry marks : ");
                        student.Chemistry = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Maths marks : ");
                        student.Maths = int.Parse(Console.ReadLine());
                        num++;
                        student.StudentId = stdId + num;
                        Console.WriteLine("");
                        Console.WriteLine("Student Registered Successfully and Student ID is : " + student.StudentId);
                        studentDetails.Add(student);

                        //creating an empty admission
                        AdmissionDetails admission = new AdmissionDetails();
                        admission.StudentId = student.StudentId;
                        admissionDetails.Add(admission);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter your Student Id");
                        string str = Console.ReadLine();
                        foreach (StudentDetails std in studentDetails)
                        {
                            if (std.StudentId == str)
                            {
                                int subOption = 0;
                                do
                                {
                                    Console.WriteLine("1. check Eligibility\n2. Show Details\n3. Take Adimission\n4. Cancel Adimission\n5. Show Admission Details\n6. Exit");
                                    subOption = int.Parse(Console.ReadLine());
                                    bool res = false;
                                    switch (subOption)
                                    {
                                        case 1:
                                            {
                                                res = std.CheckEligibility(std.Physics, std.Chemistry, std.Maths);
                                                if (res)
                                                {
                                                    Console.WriteLine("Student is eligible ");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Student is not eligible ");
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                ShowDetails(std);
                                                break;
                                            }
                                        case 3:
                                            {
                                                //Admission Area
                                                Console.WriteLine("");
                                                Console.WriteLine("DepartmentID\tDepartment Name\tNumberOfSeat");
                                                foreach (DepartmentDetails dep in departmentDetails)
                                                {
                                                    Console.WriteLine(dep.DepartmentId + "\t\t" + dep.DepartmentName + "\t\t" + dep.NumberOfSeats);
                                                }
                                                Console.WriteLine("");
                                                Console.WriteLine("Pick one department by DepartmentID");
                                                string depSelect = Console.ReadLine();
                                                foreach (DepartmentDetails dep in departmentDetails)
                                                {
                                                    if (dep.DepartmentId == depSelect)
                                                    {
                                                        bool check = std.CheckEligibility(std.Physics, std.Chemistry, std.Maths);
                                                        if (check)
                                                        {
                                                            if (dep.NumberOfSeats > 0)
                                                            {
                                                                foreach (AdmissionDetails adm in admissionDetails)
                                                                {
                                                                    if (adm.StudentId == std.StudentId)
                                                                    {
                                                                        if (adm.AdmissionStatus == AdmissionStatus.Select)
                                                                        {
                                                                            dep.NumberOfSeats--;
                                                                            adm.AdmissionDate = DateTime.Now;
                                                                            adm.AdmissionId = admId + num1;
                                                                            num1++;
                                                                            adm.AdmissionStatus = Enum.Parse<AdmissionStatus>("Booked");
                                                                            adm.DepartmentId = dep.DepartmentId;
                                                                            Console.WriteLine("");
                                                                            Console.WriteLine("Admission took successfully. Your admission ID : " + adm.AdmissionId);
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("");
                                                                            Console.WriteLine("you have already took an admission");
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("");
                                                                Console.WriteLine("Seat not available");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("");
                                                            Console.WriteLine("You are not Eligible");
                                                        }
                                                    }
                                                }
                                                break;
                                            }
                                        case 4:
                                            {
                                                //cancel
                                                Console.WriteLine("");
                                                Console.WriteLine("AdmissionID\tStudentID\tDepartmentID\tAdmissionDate\tAdmissionStatus");
                                                foreach (AdmissionDetails adm in admissionDetails)
                                                {
                                                    if (adm.AdmissionStatus == AdmissionStatus.Booked)
                                                    {
                                                        Console.WriteLine(adm.AdmissionId + "\t\t" + adm.StudentId + "\t\t" + adm.DepartmentId + "\t\t" + adm.AdmissionDate.ToString("dd/MM/yyyy") + "\t" + adm.AdmissionStatus);
                                                    }
                                                }
                                                foreach (AdmissionDetails adm in admissionDetails)
                                                {
                                                    if (adm.StudentId == std.StudentId)
                                                    {
                                                        adm.AdmissionStatus = Enum.Parse<AdmissionStatus>("Cancelled");
                                                        foreach (DepartmentDetails dep in departmentDetails)
                                                        {
                                                            if (adm.DepartmentId == dep.DepartmentId)
                                                            {
                                                                dep.NumberOfSeats++;
                                                            }
                                                        }
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Admission cancelled successfully");
                                                    }
                                                }
                                                break;
                                            }
                                        case 5:
                                            {
                                                //show Admission details
                                                foreach (AdmissionDetails adm in admissionDetails)
                                                {
                                                    if (adm.StudentId == std.StudentId)
                                                    {
                                                        Console.WriteLine("");
                                                        Console.WriteLine("AdmissionID\tStudentID\tDepartmentID\tAdmissionDate\tAdmissionStatus");
                                                        Console.WriteLine(adm.AdmissionId + "\t\t" + adm.StudentId + "\t\t" + adm.DepartmentId + "\t\t" + adm.AdmissionDate.ToString("dd/MM/yyyy") + "\t" + adm.AdmissionStatus);
                                                    }
                                                }
                                                break;
                                            }
                                        case 6:
                                            {
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("Enter valid number");
                                                break;
                                            }
                                    }

                                } while (!(subOption == 6));

                            }
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("");
                        Console.WriteLine("DepartmentID\tDepartment Name\tNumberOfSeat");
                        foreach (DepartmentDetails dep in departmentDetails)
                        {
                            Console.WriteLine(dep.DepartmentId + "\t\t" + dep.DepartmentName + "\t\t" + dep.NumberOfSeats);
                        }
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Enter valid number");
                        break;
                    }
            }

        } while (!(mainOption == 4));
    }
    static void ShowDetails(StudentDetails i)
    {
        Console.WriteLine("");
        Console.WriteLine("Your Name : " + i.StudentName);
        Console.WriteLine("Your FatherName : " + i.FatherName);
        Console.WriteLine("Your Date of birth : " + i.DOB);
        Console.WriteLine("Your Gender : " + i.Gender);
        Console.WriteLine("Your Phisics Mark : " + i.Physics);
        Console.WriteLine("Your Chemistry Mark : " + i.Chemistry);
        Console.WriteLine("Your Maths Mark : " + i.Maths);
    }
}