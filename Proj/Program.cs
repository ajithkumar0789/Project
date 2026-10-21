
using System;
using Proj.Service;
using Proj_.Models;
using Proj_.Service;

public class Program
{
    public static void Main(string[] args)
    {
        CustomerService service = new CustomerService();
        ShipmentService shipservice=new ShipmentService();

        while (true)
        {
            Console.WriteLine("\n1. Add customer");
            Console.WriteLine("2. View all customers");
            Console.WriteLine("3. Search customer");
            Console.WriteLine("4. Add Shipment");
            Console.WriteLine("5. View Shipment");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int ch))
            {
                Console.WriteLine("Enter a valid number.");
                continue;
            }

            switch (ch)
            {
                case 1:
                    Console.Write("Enter Customer ID: ");

                    if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
                    {
                        Console.WriteLine("Invalid ID.");
                        break;
                    }

                    Console.Write("Enter Full Name: ");
                    string name = Console.ReadLine() ?? "";

                    Console.Write("Enter Phone Number: ");
                    string phone = Console.ReadLine() ?? "";

                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine() ?? "";

                    if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) ||
                        string.IsNullOrWhiteSpace(address))
                    {
                        Console.WriteLine("All fields are required.");
                        break;
                    }

                    Customer customer = new Customer(id, name, phone, address);
                    service.AddCustomer(customer);
                    break;

                case 2:
                    service.ViewCustomer();
                    break;

                case 3:
                    Console.Write("Enter Customer ID to search: ");

                    if (!int.TryParse(Console.ReadLine(), out int searchId))
                    {
                        Console.WriteLine("Invalid ID.");
                        break;
                    }

                    service.SearchCustomer(searchId);
                    break;

                case 4:

                    Console.WriteLine("Enter a ShipmentId");
                    if (!int.TryParse(Console.ReadLine(), out int sid) || sid <= 0)
                    {
                        Console.Write("Enter a valid Id :");
                        break;
                    }
                    Console.Write("Enter a status :");
                    string? status = Console.ReadLine() ?? "";
                    Console.Write("Enter a location :");
                    string? location = Console.ReadLine() ?? "";
                    Console.Write("Enter a notes :");
                    string? notes = Console.ReadLine() ?? "";
                    if (string.IsNullOrWhiteSpace(status) || string.IsNullOrWhiteSpace(location))
                    {
                        Console.WriteLine("All fields are required.");
                        break;
                    }

                    ShipmentStatus sh= new ShipmentStatus(sid, status, location,notes);
                    shipservice.AddShip(sh);
                    break;

                case 5:
                    Console.WriteLine("View Shipment Status");
                    shipservice.ViewShipment();
                    break;
                case 6:
                    Console.Write("Enter Shipment ID to search: ");

                    if (!int.TryParse(Console.ReadLine(), out int sId))
                    {
                        Console.WriteLine("Invalid ID.");
                        break;
                    }

                    shipservice.Searchship(sId);
                    break;
                default:

                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
