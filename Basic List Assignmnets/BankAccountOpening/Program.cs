using System;
using System.Collections.Generic;
namespace BankAccountOpening;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to ABC Bank");
        List<CustomerDetails> customerDetails = new List<CustomerDetails>();
        int option = 0;
        int a=1000;
        do
        {
            Console.WriteLine("The Main menu\n1. Registration\n2. Login\n3. Exit");
            option = int.Parse(Console.ReadLine());
            CustomerDetails customer = new CustomerDetails();
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter your name:");
                        customer.CustomerName = Console.ReadLine();
                        Console.WriteLine("Enter your DOb");
                        customer.Dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        Console.WriteLine("Enter your gender: 1.male 2.Female");
                        customer.Gender = Enum.Parse<Gender>(Console.ReadLine(),true);
                        Console.WriteLine("Enter your phone no;");
                        customer.Phone = Console.ReadLine();
                        Console.WriteLine("Enter your Mail id:");
                        customer.MailId = Console.ReadLine();
                        Console.WriteLine("Enter the amount:");
                        customer.Balance = int.Parse(Console.ReadLine());
                        Console.WriteLine("your Customer id:");
                        customer.CustomerId ="HDFC"+a;
                        Console.WriteLine(customer.CustomerId);
                        customerDetails.Add(customer);
                        a++;
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter your Customer id");
                        string str = Console.ReadLine();
                        int count = 0;
                        foreach (CustomerDetails i in customerDetails)
                        {
                            if (i.CustomerId == str)
                            {
                                count++;
                                int num = 0;
                                do
                                {
                                    Console.WriteLine("1. Deposit\n2. withdraw\n3.balance check\n4. exit");
                                    num = int.Parse(Console.ReadLine());
                                    switch (num)
                                    {
                                        case 1:
                                            {
                                                i.Deposit();
                                                break;
                                            }
                                        case 2:
                                            {
                                                i.Withdraw();
                                                break;
                                            }
                                        case 3:
                                            {
                                                Console.WriteLine("Bank Balance: " +i.Balance);
                                                break;
                                            }
                                        case 4:
                                            {
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Enter valid no");
                                                break;
                                            }
                                    }
                                } while (!(num == 4));

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
                        Console.WriteLine("Thank you for banking with us :-)");
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