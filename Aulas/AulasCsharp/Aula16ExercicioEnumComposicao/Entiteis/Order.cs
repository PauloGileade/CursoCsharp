using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Aula16ExercicioEnumComposicao.Entiteis.Enums
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Cliente Cliente { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Cliente cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }

        public void addItem(OrderItem ordemItem)
        {
            OrderItems.Add(ordemItem);
        }

        public void removeItem(OrderItem ordemItem)
        {
            OrderItems.Remove(ordemItem);
        }
        public double Total()
        {
            double soma = 0.0;
            foreach (OrderItem total in OrderItems)
            {
                soma += total.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in OrderItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: " + Total().ToString("f2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
