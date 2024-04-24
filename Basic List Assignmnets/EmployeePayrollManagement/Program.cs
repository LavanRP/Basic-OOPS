using System;
namespace EmployeePayrollManagement;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome");
        List<EmployeDetails> employDetails = new List<EmployeDetails>();
        int option = 0;
        int a = 1000;
        do
        {
            Console.WriteLine("The Main menu\n1. Registration\n2. Login\n3. Exit");
            option = int.Parse(Console.ReadLine());
            EmployeDetails employee = new EmployeDetails();
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter your name:");
                        employee.EmployeeName = Console.ReadLine();
                        Console.WriteLine("Enter your role:");
                        employee.Role = Console.ReadLine();
                        Console.WriteLine("Enter your work location:");
                        employee.WorkLocation = Enum.Parse<Location>(Console.ReadLine(), true);
                        Console.WriteLine("Enter your team name:");
                        employee.TeamName = Console.ReadLine();
                        Console.WriteLine("Enter your joining date in dd/MM/yyyy");
                        employee.DateOfJoine = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        Console.WriteLine("Enter the no working days");
                        employee.WorkingDay = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the no Leave taken");
                        employee.Leave = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your gender:");
                        employee.Gender = Enum.Parse<Gender>(Console.ReadLine(), true);
                        employee.EmployeeId = "SF" + a;
                        Console.WriteLine(employee.EmployeeId);
                        employDetails.Add(employee);
                        a++;
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter your employee id");
                        string str = Console.ReadLine();
                        int count = 0;
                        foreach (EmployeDetails i in employDetails)
                        {
                            if (i.EmployeeId == str)
                            {
                                count++;
                                int num = 0;
                                do
                                {
                                    Console.WriteLine("1.Calculate salary\n2.Display details\n3.exit");
                                    num = int.Parse(Console.ReadLine());
                                    switch (num)
                                    {
                                        case 1:
                                            {
                                                i.SalaryCalculation();
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.WriteLine("Your name: "+i.EmployeeName);
                                                Console.WriteLine("Your role: "+i.Role);
                                                Console.WriteLine("Your work location: "+i.WorkLocation);
                                                Console.WriteLine("Your team name : "+i.TeamName);
                                                Console.WriteLine("Your joining date : "+i.DateOfJoine);
                                                Console.WriteLine("Number of working days : "+i.WorkingDay);
                                                Console.WriteLine("Number of Leave taken : "+i.Leave);
                                                Console.WriteLine("Enter your gender : "+i.Gender);
                                                Console.WriteLine("Your Employee Id : "+i.EmployeeId);
                                                break;
                                            }
                                        case 3:
                                            {
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Enter valid no");
                                                break;
                                            }
                                    }
                                } while (!(num == 3));

                            }
                        }
                        if (count == 0)
                        {
                            Console.WriteLine("Enter currect id");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Thank you :-)");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter valid number");
                        break;
                    }
            }
        } while (option != 3);
    }
}