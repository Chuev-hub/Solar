using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.DAL.Context
{
    public class Order
    {
        public int OrderId { get; set; }
        public double Price { get; set; }
        public bool IsEnded { get; set; }
        public int UserId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }


        public virtual User User { get; set; }

    }
}
