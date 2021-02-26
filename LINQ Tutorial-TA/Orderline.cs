using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Tutorial_TA
{
    class Orderline
    {

        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
