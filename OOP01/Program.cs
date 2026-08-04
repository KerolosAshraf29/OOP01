using System.Security.Cryptography.X509Certificates;
using static OOP01.Program;

namespace OOP01
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //public struct DeliveryAddress
            //{
            //    public string City;
            //    public string Street;
            //}
            //Answer a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            // DeliveryAddress Struct مش هيتأثر عشان هو Value type 
            //Expample DeliveryAddress address1;
            //address1.City = "Cairo";
            //address1.Street = "Dokki Street";
            //DeliveryAddress address2 = address1;
            //address2.City = "Alexandria";
            //Console.WriteLine(address1.City); = Cairo
            //Console.WriteLine(address2.City); = alexandria

            //public class Customer
            //{
            //    public string Name;
            //}
            //Answer b) What happens when a Customer variable is copied into another variable and one variable modifies the object?
            // class Customer بيكون Reference Type ف هيتأثر
            //Example Customer customer1 = new Customer();
            //customer1.Name = "Kerolos";
            //Customer customer2 = customer1;
            //customer2.Name = "Ashraf";
            //Console.WriteLine(customer1.Name); = Ashraf
            //Console.WriteLine(customer2.Name); = Ashraf
            #endregion
            #region Question 2
            //public class Shipment
            //{
            //public string Description;
            //public double Weight;
            //public decimal DeliveryFee;
            //}
            //a) Identify at least three problems with this design from an encapsulation perspective.
            //Answer 1. Fields kolha public wdh not secure ay hd y2dr yshofha w update 3aleha
            //       2. momken yhsl bugs w data corruption 3shan mfesh Validation
            //       3. ay hd y2dr y8yr data w y3mlha set b negative zy DelivaryFee w Weight
            //b) How can private fields and public properties improve this design?
            //Answer 1.Fields tkon kolha private 3shan mhdsh y2dr ywslha mn bra class
            //       2.Validate input to check
            //       3.Control read and write access using get set
            //       4.Maintain object integrity
            #endregion
            #region 1. Create a DeliveryAddress struct with:
            //DeliveryAddress originalAddress = new DeliveryAddress("Cairo", "Tahrir Street", 15);
            //DeliveryAddress copiedAddress = originalAddress;
            //copiedAddress.Street = "Makram Ebeid Street";
            //copiedAddress.BuildingNumber = 20;
            //Console.WriteLine("--- Struct Copy Test ---");
            //Console.WriteLine($"Original Address: {originalAddress.GetFullAddress()}");
            //Console.WriteLine($"Copied Address:   {copiedAddress.GetFullAddress()}");
            #endregion
            #region 6. In Main, build a Console Application that does the following:
            // a) Create a DeliveryCenter object
            //DeliveryCenter center = new DeliveryCenter();

            // b & c) Read data for 3 shipments
            //for (int i = 1; i <= 3; i++)
            //{
            //Console.WriteLine($"Enter Shipment {i} Data");

            //Console.Write("TrackingCode: ");
            //string code = Console.ReadLine()!;

            //Console.Write("Description: ");
            //string desc = Console.ReadLine()!;

            //Console.Write("Weight: ");
            //double weight = double.Parse(Console.ReadLine()!);

            //Console.Write("DeliveryFee: ");
            //decimal fee = decimal.Parse(Console.ReadLine()!);

            //Console.Write("City: ");
            //string city = Console.ReadLine()!;

            //Console.Write("Street: ");
            //string street = Console.ReadLine()!;

            //Console.Write("Building Number: ");
            //int bNum = int.Parse(Console.ReadLine()!);

            //DeliveryAddress address = new DeliveryAddress(city, street, bNum);
            //Shipment shipment = new Shipment(code, desc, weight, fee, address);

            //if (center.AddShipment(shipment))
            //{
            //    Console.WriteLine("Shipment added successfully.\n");
            //}
            //}
            // d) Print all shipments using integer indexer
            //Console.WriteLine("--- All Shipments ---");
            //for (int i = 0; i < 3; i++)
            //{
            //Shipment? s = center[i];
            //if (s != null)
            //{
            //s.PrintShipment();
            //Console.WriteLine();
            //}
            //}
            // e / f / g) Search by tracking code
            //Console.Write("Enter a tracking code to search: ");
            //string searchCode = Console.ReadLine()!;

            //Shipment? foundShipment = center[searchCode];
            //if (foundShipment != null)
            //{
            //Console.WriteLine($"Shipment found: {foundShipment.TrackingCode} - {foundShipment.Description}");
            //}
            //else
            //{
            //Console.WriteLine("Shipment not found.");
            //}
            // h) Struct Copy Test
            //Console.WriteLine("\n--- Struct Copy Test ---");
            //DeliveryAddress originalAddress = new DeliveryAddress("Cairo", "Tahrir Street", 15);
            //DeliveryAddress copiedAddress = originalAddress;

            //copiedAddress.Street = "Makram Ebeid Street";
            //copiedAddress.BuildingNumber = 20;

            //Console.WriteLine($"Original Address: {originalAddress.GetFullAddress()}");
            //Console.WriteLine($"Copied Address: {copiedAddress.GetFullAddress()}");
            #endregion
        }
    }
}
