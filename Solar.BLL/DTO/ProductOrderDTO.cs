using Solar.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.BLL.DTO
{
    public class ProductOrderDTO
    {
        public int ProductOrderId { get; set; }
        public int GuitarId { get; set; }
        public int OrderId { get; set; }
        public GuitarDTO Guitar { get; set; }

    }
}
