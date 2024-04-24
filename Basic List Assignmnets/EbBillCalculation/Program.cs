using System;
using System.Collections.Generic;
namespace EbBillCalculation;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome");
        List<EbDetails> ebDetails = new List<EbDetails>();
        int option = 0;
        int a = 1000;
        int b=100;
        do
        {
            Console.WriteLine("The Main menu\n1. Registration\n2. Login\n3. Exit");
            option = int.Parse(Console.ReadLine());
            EbDetails user = new EbDetails();
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter your name:");
                        user.UserName = Console.ReadLine();
                        Console.WriteLine("Enter your phone no;");
                        user.PhoneNo = Console.ReadLine();
                        Console.WriteLine("Enter your Mail id:");
                        user.MailId = Console.ReadLine();
                        Console.WriteLine("your Meter id:");
                        user.UserId = "EB" + a;
                        Console.WriteLine(user.UserId);
                        ebDetails.Add(user);
                        a++;
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter your Customer id");
                        string str = Console.ReadLine();
                        int count = 0;
                        foreach (EbDetails i in ebDetails)
                        {
                            if (i.UserId == str)
                            {
                                count++;
                                int num = 0;
                                do
                                {
                                    Console.WriteLine("1.Calculated amount\n2.Display user details\n3.exit");
                                    num = int.Parse(Console.ReadLine());
                                    switch (num)
                                    {
                                        case 1:
                                            { 
                                                Console.WriteLine("Enter no unit used:");
                                                i.UnitUsed = int.Parse(Console.ReadLine());
                                                i.BillId="BId"+b;
                                                i.CalculateAmount();
                                                Console.WriteLine("Your bill id : "+i.BillId);
                                                Console.WriteLine("Your name : "+i.UserName);
                                                Console.WriteLine("Total unit used : "+i.UnitUsed);
                                                Console.WriteLine("Total amount : "+i.Amount);
                                                b++;
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.WriteLine("Your Meter Id : "+i.UserId);
                                                Console.WriteLine("Your name : "+i.UserName);
                                                Console.WriteLine("Your phone no : "+i.PhoneNo);
                                                Console.WriteLine("Your mail id : "+i.MailId);
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
