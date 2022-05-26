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
    public class UserService
    {
        IRepository<User> Repository;
        IMapper mapper;
        public ObService ObService { get; set; } = new ObService();
        public UserService(IRepository<User> repository)
        {
            Repository = repository;


            MapperConfiguration config = new MapperConfiguration(x =>
            {
                x.CreateMap<User, UserDTO>().ForMember(y => y.Orders, e => e.MapFrom(r => ObService.GetAllOrders(r.Orders)));
                x.CreateMap<UserDTO, User>().ForMember(y => y.Orders, e => e.MapFrom(r => ObService.GetAllOrderss(r.Orders)));
            });

            mapper = new Mapper(config);
            
        }

        public IEnumerable<UserDTO> GetAll()
        {
            return mapper.Map<IEnumerable<User>, IEnumerable<UserDTO>>(Repository.GetAll());
        }

        public UserDTO Get(int goodId)
        {
            UserDTO imageSiteDTO = mapper.Map<User, UserDTO>(Repository.Get(goodId));

            return imageSiteDTO;
        }

        public UserDTO Delete(UserDTO goodDto)
        {
            User goodToRemove = Repository.Get(goodDto.UserId);
            Repository.Delete(goodToRemove);
            Repository.SaveChanges();
            return goodDto;
        }

        public void CreateOrUpdate(UserDTO goodDto)
        {
            User good = mapper.Map<UserDTO, User>(goodDto);
            Repository.CreateOrUpdate(good);
            Repository.SaveChanges();
        }
    }
}
