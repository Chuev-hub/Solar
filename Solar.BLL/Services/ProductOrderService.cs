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
     public class ProductOrderService
    {
        IRepository<ProductOrder> Repository;
        IMapper mapper;
       
        static  IRepository<Guitar> GuitarRepository = new GuitarRepository(new SiteContext());
        GuitarService GuitarService = new GuitarService(GuitarRepository);
        public ProductOrderService(IRepository<ProductOrder> repository)
        {
            Repository = repository;



            MapperConfiguration config = new MapperConfiguration(x =>
            {
                x.CreateMap<ProductOrder, ProductOrderDTO>().ForMember(y=>y.Guitar,h=>h.MapFrom(s=> GuitarService.Get( s.Guitar.GuitarId)));
                x.CreateMap<ProductOrderDTO, ProductOrder>().ForMember(y => y.Guitar, h => h.MapFrom(s => GuitarRepository.Get(s.Guitar.GuitarId))); ;
            });

            mapper = new Mapper(config);
        }

        public IEnumerable<ProductOrderDTO> GetAll()
        {
            return mapper.Map<IEnumerable<ProductOrder>, IEnumerable<ProductOrderDTO>>(Repository.
                GetAll());
        }

        public ProductOrderDTO Get(int goodId)
        {
            ProductOrderDTO imageSiteDTO = mapper.Map<ProductOrder, ProductOrderDTO>(Repository.Get(goodId));

            return imageSiteDTO;
        }

        public ProductOrderDTO Delete(ProductOrderDTO goodDto)
        {
            ProductOrder goodToRemove = Repository.Get(goodDto.ProductOrderId);
            Repository.Delete(goodToRemove);
            Repository.SaveChanges();
            return goodDto;
        }

        public void CreateOrUpdate(ProductOrderDTO goodDto)
        {
            ProductOrder good = mapper.Map<ProductOrderDTO, ProductOrder>(goodDto);
            Repository.CreateOrUpdate(good);
            Repository.SaveChanges();
        }
    }
}
