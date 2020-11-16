using System;
using EnumEx.Entities;
using EnumEx.Entities.Enums;

namespace EnumEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPaument
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPaument.ToString();
            Console.WriteLine(txt);

            //Convertendo string para enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

        }
    }
}
