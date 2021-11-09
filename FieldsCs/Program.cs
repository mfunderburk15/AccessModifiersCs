using System;

namespace FieldsCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);
        }
    }
}
