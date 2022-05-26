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
    public class UserBasketService
    {
        IRepository<UsersBasket> Repository;
        IMapper mapper;
        GuitarService GuitarService = new GuitarService(new GuitarRepository(new SiteContext()));
        public UserBasketService(IRepository<UsersBasket> repository)
        {
            Repository = repository;



            MapperConfiguration config = new MapperConfiguration(x =>
            {


                x.CreateMap<UsersBasket, UsersBasketDTO>()
                .ForMember(y=>y.Guitar,d=>d.MapFrom(f=>GuitarService.Get(f.Guitar.GuitarId)));

                x.CreateMap<UsersBasketDTO, UsersBasket>()
                .ForMember(y=>y.Guitar,d=>d.MapFrom(f=>GuitarService.GetRep(f.Guitar.GuitarId)));
                ;
            });

            mapper = new Mapper(config);
        }

        public IEnumerable<UsersBasketDTO> GetAll()
        {
            return mapper.Map<IEnumerable<UsersBasket>, IEnumerable<UsersBasketDTO>>(Repository.
                GetAll());
        }

        public UsersBasketDTO Get(int goodId)
        {
            UsersBasketDTO imageSiteDTO = mapper.Map<UsersBasket, UsersBasketDTO>(Repository.Get(goodId));

            return imageSiteDTO;
        }

        public UsersBasketDTO Delete(UsersBasketDTO goodDto)
        {
            UsersBasket goodToRemove = Repository.Get(goodDto.UsersBasketId);
            Repository.Delete(goodToRemove);
            Repository.SaveChanges();
            return goodDto;
        }

        public void CreateOrUpdate(UsersBasketDTO goodDto)
        {
            UsersBasket good = new UsersBasket() { UserId = goodDto.UserId, GuitarId = goodDto.Guitar.GuitarId };
            Repository.CreateOrUpdate(good);
            Repository.SaveChanges();
        }
    }

}
