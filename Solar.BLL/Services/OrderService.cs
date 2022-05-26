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
    public class OrderService
    {
        IRepository<Order> Repository;
        IMapper mapper;
        ObService OBS = new ObService();
        public OrderService(IRepository<Order> repository)
        {
            Repository = repository;
          
            MapperConfiguration config = new MapperConfiguration(x =>
            {
                x.CreateMap<Order, OrderDTO>().ForMember(y => y.UserName, u => u.MapFrom(r => r.User.Name)).
                ForMember(y => y.UserSurName, u => u.MapFrom(r => r.User.SurName));
                x.CreateMap<OrderDTO, Order>();
            });
            mapper = new Mapper(config);
        }

        public IEnumerable<OrderDTO> GetAll()
        {
            return mapper.Map<IEnumerable<Order>, IEnumerable<OrderDTO>>(Repository.GetAll());
        }
        public ICollection<OrderDTO> GetAlls(ICollection<Order> d)
        {
            return mapper.Map<ICollection<Order>, ICollection<OrderDTO>>(d);
        }
        public OrderDTO Get(int goodId)
        {
            OrderDTO imageSiteDTO = mapper.Map<Order, OrderDTO>(Repository.Get(goodId));

            return null;
        }

        public OrderDTO Delete(OrderDTO goodDto)
        {
            Order goodToRemove = Repository.Get(goodDto.OrderId);
            Repository.Delete(goodToRemove);
            Repository.SaveChanges();
            return goodDto;
        }

        public void CreateOrUpdate(OrderDTO goodDto)
        {
            Order good = mapper.Map<OrderDTO, Order>(goodDto);
            Repository.CreateOrUpdate(good);
            Repository.SaveChanges();
        }
    }
}
