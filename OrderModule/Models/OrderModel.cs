using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Models
{
   public class OrderModel
    {
        public int sipId { get; set; }
        public int itemRef { get; set; }
        public double itemPrice { get; set; }
        public double amount { get; set; }
        public int clientref { get; set; }
    }
}
