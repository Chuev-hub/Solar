using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.DAL.Context
{
    public class GuitarCategory
    {
        public int GuitarCategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Guitar> Guitars { get; set; } = new HashSet<Guitar>();
    }
}
