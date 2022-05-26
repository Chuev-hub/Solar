using Solar.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.DAL.Repositories
{
    public class ProductOrderRepository : GenericRepository<ProductOrder>
    {
        public ProductOrderRepository(DbContext context) : base(context)
        {
            try
            {
                ProductOrder g = context.Set<ProductOrder>()
                                .Include(c => c.Order)
                                .Include(c => c.Guitar).ToList()[0];
            }
            catch { }
        }
    }
}
