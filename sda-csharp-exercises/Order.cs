using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Order
    {
        OrderItem[] orderItems;

        public Order(OrderItem[] orderItems)
        {
            this.orderItems = orderItems;
        }

        public void PrintSummary()
        {
            decimal total = 0;

            foreach (OrderItem item in orderItems)
            {
                total += item.GetValue();
            }
            Console.WriteLine($"Wartosc zamowienia: { total} PLN");
        }

    }
}
