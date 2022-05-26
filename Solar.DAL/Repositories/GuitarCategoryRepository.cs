using Solar.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.DAL.Repositories
{
    public class GuitarCategoryRepository : GenericRepository<GuitarCategory>
    {
        public GuitarCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
