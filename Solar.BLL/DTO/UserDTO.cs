using Solar.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.BLL.DTO
{
   public class UserDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }

        public  ICollection<OrderDTO> Orders { get; set; } = new HashSet<OrderDTO>();
    }
}
