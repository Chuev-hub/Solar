using Solar.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.DAL.Repositories
{
 
    public class UsersBasketRepository : GenericRepository<UsersBasket>
    {
        public UsersBasketRepository(DbContext context) : base(context)
        {
            try
            {
                UsersBasket g = context.Set<UsersBasket>()
                                .Include(c => c.Users)
                                .Include(c => c.Guitar).ToList()[0];
            }
            catch { }
        }
      

    }
}
