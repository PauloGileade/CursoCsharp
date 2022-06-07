using System;
using System.Globalization;

namespace Aula16ExercicioEnumComposicao.Entiteis.Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(name, email, date);

            Console.Write("\nStatus: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, cliente);

            Console.Write("\nHow many items to this order ?");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine();

            OrderItem orderItem = new OrderItem();
            Product product = new Product();

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                product = new Product(productName, price);
                orderItem = new OrderItem(productQuantity, price, product);
                order.addItem(orderItem);
            }

            Console.WriteLine();

            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
            
        }   
    }
}
