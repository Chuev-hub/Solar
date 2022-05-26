using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.BLL.DTO
{
    public class UsersBasketDTO
    {
        public GuitarDTO Guitar { get; set; }
        public int UserId { get; set; }
        public int UsersBasketId { get; set; }
    }
}
