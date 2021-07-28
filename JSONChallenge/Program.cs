using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            PhilsDemo();
            Challenge1();
            Challenge2();
            Challenge3();
            Bonus();
        }

        public static void DisplayJson(string challengeName, ObjectForJson obj)
        {
            Console.Clear();
            Console.WriteLine("_____" + challengeName + "_____");

            string json = JsonConvert.SerializeObject(obj);

            Console.WriteLine(json);

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public static void PhilsDemo()
        {
            Person person = new Person();

            person.FirstName = "Christopher";
            person.LastName = "Weaver";
            person.DOB = new DateTime(2000, 1, 1);
            person.FavoriteIceCreamFlavors = new List<string>
            {
                "Strawberry",
                "Cookie Dough"
            };

            DisplayJson("Phil's Demo", person);
        }

        public static void Challenge1()
        {
            Event someEvent = new Event();

            someEvent.StartDate = new DateTime(2021, 7, 27);
            someEvent.EndDate = new DateTime(2021, 7, 31);
            someEvent.EventTitle = "Gen Con";
            someEvent.EventCapacity = 10000;
            someEvent.PriceOfAdmission = 325.50m;

            DisplayJson("Challenge #1", someEvent);
        }

        public static void Challenge2()
        {
            Badge badge = new Badge();

            badge.BadgeID = 12345;
            badge.ListOfDoors = new List<string>
            {
                "A1",
                "B2",
                "B5",
                "G21"
            };
            badge.HasSecurityClearance = true;
            badge.EmployeeId = "F54G678HJ32321S";
            badge.CreatedOn = DateTime.Now;

            DisplayJson("Challenge #2", badge);
        }

        public static void Challenge3()
        {
            Console.Clear();
            Console.WriteLine("Please see Vehicle.json in project solution.");
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public static void Bonus()
        {
            Order order = new Order();
            Customer customer = new Customer();
            ShippingAddress shippingAddress = new ShippingAddress();
            List<Product> lineItems;
            Product product1 = new Product();
            Product product2 = new Product();

            shippingAddress.AddressLine1 = "123 Main St";
            shippingAddress.AddressLine2 = "Apt C";
            shippingAddress.City = "Indianapolis";
            shippingAddress.State = "IN";
            shippingAddress.Zip = "46202";

            customer.FirstName = "Taylor";
            customer.LastName = "Jones";
            customer.PhoneNumber = "(733) 265-3421";
            customer.ShippingAddress = shippingAddress;

            product1.Sku = "GH12345";
            product1.Quantity = 1;
            product1.UnitPrice = 2.34m;

            product2.Sku = "DR123-09";
            product2.Quantity = 2;
            product2.UnitPrice = 5.00m;

            lineItems = new List<Product>
            {
                product1,
                product2
            };

            order.OrderId = "C-12345";
            order.Customer = customer;
            order.LineItems = lineItems;
            order.PurchaseDate = DateTime.Now;

            DisplayJson("Bonus", order);
        }
    }
}
