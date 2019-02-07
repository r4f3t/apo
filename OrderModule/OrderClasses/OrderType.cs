using Interfaces;
using OrderModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.OrderClasses
{
   public  class OrderType:IMoveType
    {
        OrderModel _orderModel;
        public OrderType(OrderModel orderModel)
        {
            _orderModel = orderModel;

        }
        public void MakeInsert()
        {
            Console.WriteLine("Sipariş Verilen ÜrünId:" + _orderModel.itemRef);
            Console.WriteLine("Sipariş Verilen ClientId:" + _orderModel.clientref);
        }
    }
}
