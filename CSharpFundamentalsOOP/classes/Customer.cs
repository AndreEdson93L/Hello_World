using System.Collections.Generic;

namespace CSharpFundamentalsOOP
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        //costruttori
        public Customer()
        {
            Orders = new List<Order>();
        }
        //overload costruttori
        public Customer(int id)
            : this()
        {
            Id = id;
        }
        public Customer(int id, string name)
            : this(id)
        {
            Name = name;
        }
        //ref modifier
        public static void AddTwo(ref int num)
        {
            num += 2;
        }
        //out modifier
        public static void InitializeNumberToOne(out int num)
        {
            num = 1;
        }
        public static void VirtualMain()
        {
            //object initializer
            var customer0 = new Customer { Id = 5, Name = "Luigi" };
            var customer1 = new Customer(1, "Mario");

            //ref modifier
            var numero = 1;
            Customer.AddTwo(ref numero);
            System.Console.WriteLine(numero);

            //out modifier
            int num;
            Customer.InitializeNumberToOne(out num);
            System.Console.WriteLine(num);

            var order = new Order();
            customer1.Orders = new List<Order>();
            customer1.Orders.Add(order);

            System.Console.WriteLine(customer0.Id);
            System.Console.WriteLine(customer0.Name);

            System.Console.WriteLine(customer1.Id);
            System.Console.WriteLine(customer1.Name);
        }
    }
}
