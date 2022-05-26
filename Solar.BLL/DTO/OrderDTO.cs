using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.BLL.DTO
{
   public class OrderDTO
    {
        public int OrderId { get; set; }
        public double Price { get; set; }
        public bool IsEnded { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Fill { get { if (IsEnded == true) return "Green"; else return "Yellow"; } }
    }
}
