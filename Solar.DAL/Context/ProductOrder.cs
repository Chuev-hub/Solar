using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.DAL.Context
{
    public class ProductOrder
    {
        public int ProductOrderId { get; set; }
        public int GuitarId { get; set; }
        public int OrderId { get; set; }
       

        public virtual Guitar Guitar { get; set; }
        public virtual Order Order { get; set; }
    }
}
