using System.Collections.Generic;

namespace CSharpFundamentalsOOP
{
    public class Cliente
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();
        //costruttori
        public Cliente(int id)
        {
            Id = id;
        }
        public Cliente(int id, string name)
        {
            Id = id;
            Name = name;
        }
        //metodi della classe
        public void Promote()
        {
            System.Console.WriteLine("There's a promotion.");
        }
        public static void VirtualMain()
        {
            var cliente = new Cliente(0, "Melissa");

            cliente.Promote();
            cliente.Orders.Add(new Order());
            cliente.Orders.Add(new Order());

            System.Console.WriteLine(cliente.Orders.Count);
        }
    }
}
