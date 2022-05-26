using AutoMapper;
using Solar.BLL.DTO;
using Solar.DAL.Context;
using Solar.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.BLL.Services
{
    public class ObService
    {
        IRepository<User> UserRepository = new UserRepository(new SiteContext());
        IRepository<Order> OrderRepository= new OrderRepository(new SiteContext());
     
        IMapper mapper;
        public ObService()
        {
           
            MapperConfiguration config = new MapperConfiguration(x =>
            {
                x.CreateMap<User, UserDTO>().ForMember(y => y.Orders, e => e.MapFrom(r => GetAllOrders(r.Orders)));
                x.CreateMap<UserDTO, User>();
                x.CreateMap<Order, OrderDTO>().ForMember(y => y.UserName, u => u.MapFrom(r => r.User.Name)).
                 ForMember(y => y.UserSurName, u => u.MapFrom(r => r.User.SurName));
                 x.CreateMap<OrderDTO, Order>().ForMember(y => y.User, u => u.MapFrom(r => GetUser(r.UserId)));
            });

            mapper = new Mapper(config);
        }
        
        public UserDTO GetUser(int goodId)
        {
            UserDTO imageSiteDTO = mapper.Map<User, UserDTO>(UserRepository.Get(goodId));

            return imageSiteDTO;
        }
        public ICollection<OrderDTO> GetAllOrders(ICollection<Order> d)
        {
            return mapper.Map<ICollection<Order>, ICollection<OrderDTO>>(d);
        }
        public ICollection<Order> GetAllOrderss(ICollection<OrderDTO> d)
        {
            return mapper.Map<ICollection<OrderDTO>, ICollection<Order>>(d);
        }

    }
}

