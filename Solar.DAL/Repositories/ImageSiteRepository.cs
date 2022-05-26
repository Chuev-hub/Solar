using Solar.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.DAL.Repositories
{
    public class ImageSiteRepository : GenericRepository<ImageSite>
    {
        public ImageSiteRepository(DbContext context) : base(context)
        {
        }
    }
}
