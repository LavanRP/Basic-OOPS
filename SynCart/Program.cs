using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace SynCart;
class Program
{
    public static void Main(string[] args)
    {
        List<ProductDetails> productDetails = new List<ProductDetails>();
        //Adding data About Product
        ProductDetails product1 = new ProductDetails();
        product1.ProductID = "PID101";
        product1.ProductName = "Mobile (Samsung)";
        product1.Stock = 10;
        product1.Price = 10000;
        product1.ShippingDuration = 3;
        productDetails.Add(product1);

        ProductDetails product2 = new ProductDetails();
        product2.ProductID = "PID102";
        product2.ProductName = "Tablet (Lenovo)";
        product2.Stock = 5;
        product2.Price = 15000;
        product2.ShippingDuration = 2;
        productDetails.Add(product2);

        ProductDetails product3 = new ProductDetails();
        product3.ProductID = "PID103";
        product3.ProductName = "Camara (Sony)";
        product3.Stock = 3;
        product3.Price = 20000;
        product3.ShippingDuration = 4;
        productDetails.Add(product3);

        ProductDetails product4 = new ProductDetails();
        product4.ProductID = "PID104";
        product4.ProductName = "iPhone ";
        product4.Stock = 5;
        product4.Price = 50000;
        product4.ShippingDuration = 5;
        productDetails.Add(product4);

        ProductDetails product5 = new ProductDetails();
        product5.ProductID = "PID105";
        product5.ProductName = "Laptop (Lenovo I3)";
        product5.Stock = 3;
        product5.Price = 40000;
        product5.ShippingDuration = 3;
        productDetails.Add(product5);

        ProductDetails product6 = new ProductDetails();
        product6.ProductID = "PID106";
        product6.ProductName = "HeadPhone (Boat)";
        product6.Stock = 5;
        product6.Price = 1000;
        product6.ShippingDuration = 2;
        productDetails.Add(product6);

        ProductDetails product7 = new ProductDetails();
        product7.ProductID = "PID107";
        product7.ProductName = "Speakers (Boat)";
        product7.Stock = 4;
        product7.Price = 500;
        product7.ShippingDuration = 2;
        productDetails.Add(product7);

        List<CustomerDetails> customerDetails = new List<CustomerDetails>();
        List<OrderDetails> orderDetails = new List<OrderDetails>();
        Console.WriteLine("-----Welcome to SynCart-----");
        Console.WriteLine("****************************");
        int mainOption;
        int cNum = 1001;
        string cStr = "CID";
        int oNum = 1001;
        string oStr = "OID";
        do
        {
            Console.WriteLine("1. Customer Registration\n2. Login\n3. Exit");
            mainOption = int.Parse(Console.ReadLine());
            switch (mainOption)
            {
                case 1:
                    {
                        //customer Registration
                        CustomerDetails customer = new CustomerDetails();
                        Console.WriteLine("Enter Your Name");
                        customer.Name = Console.ReadLine();
                        Console.WriteLine("Enter your City");
                        customer.City = Console.ReadLine();
                        Console.WriteLine("Enter your Phone number");
                        customer.PhoneNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Mail ID");
                        customer.EmailID = Console.ReadLine();
                        Console.WriteLine("Enter your WalletBalance");
                        customer.WalletBalance = int.Parse(Console.ReadLine());
                        customer.CustomerID = cStr + cNum;
                        Console.WriteLine("Your Customer ID : " + customer.CustomerID);
                        cNum++;
                        customerDetails.Add(customer);
                        break;
                    }
                case 2:
                    {
                        //login
                        Console.WriteLine("Enter your customer ID");
                        string str = Console.ReadLine();
                        foreach (CustomerDetails cus in customerDetails)
                        {
                            if (cus.CustomerID == str)
                            {
                                char subOption;
                                do
                                {
                                    Console.WriteLine("a. Purchase\nb. Order History\nc. Cancel Order\nd. Wallet Balance\ne. WalletRecharge\nf. Exit");
                                    subOption = char.Parse(Console.ReadLine());
                                    switch (subOption)
                                    {
                                        case 'a':
                                            {
                                                //Purchase
                                                Console.WriteLine("ProductID\tProduct Name\tAvailable Stock\t\tPrice Per Quantity\tShipping Duration");
                                                Console.WriteLine("");
                                                foreach (ProductDetails pro in productDetails)
                                                {
                                                    Console.WriteLine("{0,-15}{1,-25}{2,-20}{3,-23}{4,-6}",pro.ProductID,pro.ProductName,pro.Stock,pro.Price,pro.ShippingDuration);
                                                }
                                                Console.WriteLine("Choose the product by it's ID");
                                                string pID = Console.ReadLine();
                                                int count = 0;
                                                foreach (ProductDetails pro in productDetails)
                                                {
                                                    if (pro.ProductID.Equals(pID))
                                                    {
                                                        count++;
                                                        Console.WriteLine("How Many dou you want?");
                                                        int pCount = int.Parse(Console.ReadLine());
                                                        if (pCount <= pro.Stock)
                                                        {
                                                            int amount = (pCount * pro.Price) + 50;
                                                            if (amount < cus.WalletBalance)
                                                            {
                                                                cus.DeductBalance(amount);
                                                                pro.Stock = pro.Stock - pCount;
                                                                OrderDetails order = new OrderDetails();
                                                                order.OrderID = oStr + oNum;
                                                                oNum++;
                                                                order.CustomerID = cus.CustomerID;
                                                                order.ProductID = pro.ProductID;
                                                                order.TotalPrice = amount;
                                                                order.PurchaseDate = DateTime.Now;
                                                                order.Quantity = pCount;
                                                                order.OrderStatus = OrderStatus.Ordered;
                                                                orderDetails.Add(order);

                                                                Console.WriteLine("Order Placed Successfully. Order ID : " + order.OrderID);
                                                                Console.WriteLine("Your order will reach you in " + order.PurchaseDate.AddDays(pro.ShippingDuration).ToString("dd/MM/yyyy"));
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Insufficent Balance. Please recharge your wallet and do purchase again");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Required count not available. Current availability is {pro.Stock}");
                                                        }
                                                    }
                                                }
                                                if (count == 0)
                                                {
                                                    Console.WriteLine("Invalid ProductID");
                                                }
                                                break;
                                            }
                                        case 'b':
                                            {
                                                //Order History
                                                Console.WriteLine("Order ID\tCustomer ID\tProductID\tTotalPrice\tPurchase Date\tQuantity Purchased\tOrder Status");
                                                Console.WriteLine("");
                                                foreach (OrderDetails ord in orderDetails)
                                                {
                                                    if (ord.CustomerID == cus.CustomerID)
                                                    {
                                                        Console.WriteLine(ord.OrderID + "\t\t" + ord.CustomerID + "\t\t" + ord.ProductID + "\t\t" + ord.TotalPrice + "\t\t" + ord.PurchaseDate.ToString("dd/MM/yyyy") + "\t\t" + ord.Quantity + "\t\t" + ord.OrderStatus);
                                                    }
                                                }
                                                break;
                                            }
                                        case 'c':
                                            {
                                                //Cancel Order
                                                int num = 0;
                                                foreach (OrderDetails ord in orderDetails)
                                                {
                                                    if ((ord.CustomerID == cus.CustomerID) && (ord.OrderStatus == OrderStatus.Ordered))
                                                    {
                                                        num++;
                                                    }
                                                }
                                                if (num != 0)
                                                {
                                                    Console.WriteLine("Order ID\tCustomer ID\tProductID\tTotalPrice\tPurchase Date\tQuantity Purchased\tOrder Status");
                                                    Console.WriteLine("");
                                                    foreach (OrderDetails ord in orderDetails)
                                                    {
                                                        if ((ord.CustomerID == cus.CustomerID) && (ord.OrderStatus == OrderStatus.Ordered))
                                                        {
                                                            Console.WriteLine(ord.OrderID + "\t\t" + ord.CustomerID + "\t\t" + ord.ProductID + "\t\t" + ord.TotalPrice + "\t\t" + ord.PurchaseDate.ToString("dd/MM/yyyy") + "\t\t" + ord.Quantity + "\t\t" + ord.OrderStatus);
                                                        }
                                                    }
                                                    Console.WriteLine("Enter the orderId that you want to cancel");
                                                    string cancel = Console.ReadLine();
                                                    int count = 0;
                                                    foreach (OrderDetails ord in orderDetails)
                                                    {
                                                        if (ord.OrderID.Equals(cancel))
                                                        {
                                                            count++;
                                                            foreach (ProductDetails pro in productDetails)
                                                            {
                                                                if (pro.ProductID.Equals(ord.ProductID))
                                                                {
                                                                    pro.Stock = pro.Stock + ord.Quantity;
                                                                    cus.WalletBalance = cus.WalletBalance + ord.TotalPrice;
                                                                    ord.OrderStatus = OrderStatus.Cancelled;
                                                                    Console.WriteLine($"Order : {ord.OrderID} Cancelled Successfully");
                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (count == 0)
                                                    {
                                                        Console.WriteLine("Invalid orderID");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You have not purchased any thing or you have cancled the all the placed order");
                                                }
                                                break;
                                                
                                            }
                                        case 'd':
                                            {
                                                //Wallet Balance
                                                Console.WriteLine($"Your wallet Balance {cus.WalletBalance}");
                                                break;
                                            }
                                        case 'e':
                                            {
                                                //WalletRecharge
                                                Console.WriteLine("Do you Wish to Recharge the wallet ->yes or no");
                                                string res = "";
                                                do
                                                {
                                                    res = Console.ReadLine();
                                                    if (res.Equals("yes"))
                                                    {
                                                        Console.WriteLine("Enter the amount to be recharged");
                                                        int amount = int.Parse(Console.ReadLine());
                                                        cus.WalletRecharge(amount);
                                                        Console.WriteLine("Updated Wallet Balance " + cus.WalletBalance);
                                                        break;
                                                    }
                                                    else if (!(res.Equals("no")))
                                                    {
                                                        Console.WriteLine("choose only yes or no");
                                                    }
                                                } while (!(res.Equals("no")));
                                                break;
                                            }
                                        case 'f':
                                            {
                                                //Exit
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("invalid Entry");
                                                break;
                                            }
                                    }
                                } while (!(subOption.Equals('f')));
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
                        Console.WriteLine("invalid number");
                        break;
                    }
            }
        } while (!(mainOption == 3));
    }
}
