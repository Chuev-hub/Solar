using Solar.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.DAL.Repositories
{
    public class OrderRepository : GenericRepository<Order>
    {
        public OrderRepository(DbContext context) : base(context)
        {
            try
            {
                Order g = context.Set<Order>().Include(c=>c.User)
                               .ToList()[0];
            }
            catch { }
        }
    }
}
