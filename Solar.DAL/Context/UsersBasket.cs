using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.DAL.Context
{
    public class UsersBasket
    {
        public int UsersBasketId { get; set; }
        public int GuitarId { get; set; }
        public int UserId { get; set; }

        public virtual Guitar Guitar { get; set; }
        public virtual User Users { get; set; }
    }
}
