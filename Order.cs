using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_Hungary_for_hungry
{
    internal class Order
    {
        public string id = "";
        public string OrderNote = "";
        public DateTime date;
        public string status = "";
        public Cart cart = new Cart();
    }
}
