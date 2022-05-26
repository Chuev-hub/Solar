using AutoMapper;
using Solar.BLL.DTO;
using Solar.DAL.Context;
using Solar.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar.BLL.Services
{
    public class ImageSiteService
    {
        IRepository<ImageSite> Repository;
        IMapper mapper;
        public ImageSiteService(IRepository<ImageSite> repository)
        {
            Repository = repository;


            
            MapperConfiguration config = new MapperConfiguration(x =>
            {
                x.CreateMap<ImageSite, ImageSiteDTO>();
              
                x.CreateMap<ImageSiteDTO, ImageSite>();
            });

            mapper = new Mapper(config);
        }

        public IEnumerable<ImageSiteDTO> GetAll()
        {
            return mapper.Map<IEnumerable<ImageSite>, IEnumerable<ImageSiteDTO>>(Repository.GetAll());
        }

        public ImageSiteDTO Get(int goodId)
        {
            ImageSiteDTO imageSiteDTO = new ImageSiteDTO() { ImageSiteId = Repository.Get(goodId).ImageSiteId, Photo = Repository.Get(goodId).Photo };
           
            return imageSiteDTO;
        }

        public ImageSiteDTO Delete(ImageSiteDTO goodDto)
        {
            ImageSite goodToRemove = Repository.Get(goodDto.ImageSiteId);
            Repository.Delete(goodToRemove);
            Repository.SaveChanges();
            return goodDto;
        }

        public void CreateOrUpdate(ImageSiteDTO goodDto)
        {
            ImageSite good = mapper.Map<ImageSiteDTO, ImageSite>(goodDto);
            Repository.CreateOrUpdate(good);
            Repository.SaveChanges();
        }
    }
}
