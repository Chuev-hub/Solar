using AutoMapper;
using Solar.BLL.DTO;
using Solar.DAL.Context;
using Solar.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Solar.BLL.Services
{
    public class GuitarService
    {
        IRepository<Guitar> Repository;
        IMapper mapper;
        public ImageSiteService imageSiteService { get; set; } = new ImageSiteService(new ImageSiteRepository(new SiteContext()));

        public GuitarService(IRepository<Guitar> repository)
        {
            Repository = repository;
            MapperConfiguration config = new MapperConfiguration(x =>
            {


                x.CreateMap<Guitar, GuitarDTO>();
                    //.ForMember(y => y.MainPhoto, y => y.MapFrom(prop => GetPhoto(prop.MainPhotoId)))
                    //.ForMember(y => y.SecondPhoto, y => y.MapFrom(prop => GetPhoto(prop.SecondPhotoId)))
                    //.ForMember(y => y.ThirdPhoto, y => y.MapFrom(prop => GetPhoto(prop.ThirdPhotoId)))
                    //.ForMember(y => y.CharacteristicPhoto, y => y.MapFrom(prop => GetPhoto(prop.CharacteristicPhotoId)));
                x.CreateMap<GuitarDTO, Guitar>();
            });

            mapper = new Mapper(config);
        }

        public IEnumerable<GuitarDTO> GetAll()
        {
            ObservableCollection<GuitarDTO> dto = new ObservableCollection<GuitarDTO>();
            ObservableCollection<Guitar> guitars = new ObservableCollection<Guitar>(Repository.GetAll());
            for (int i = 0; i < guitars.Count(); i++)
                dto.Add(new GuitarDTO()
                {
                    Bridge = guitars[i].Bridge,
                    Color = guitars[i].Color,
                    Info = guitars[i].Info,
                    LeftHanded = guitars[i].LeftHanded,
                    GuitarCategoryName = guitars[i].GuitarCategory.Name,
                    Name = guitars[i].Name,
                    Material = guitars[i].Material,
                    Middle = guitars[i].Middle,
                    Neck = guitars[i].Neck,
                    Price = guitars[i].Price,
                    NumberOfStrings = guitars[i].NumberOfStrings,
                    GuitarCategoryId = guitars[i].GuitarCategoryId,
                    Shape = guitars[i].Shape,
                    Switch = guitars[i].Switch,
                    CharacteristicPhotoId = guitars[i].CharacteristicPhotoId,
                    MainPhotoId = guitars[i].MainPhotoId,
                    GuitarId = guitars[i].GuitarId,
                    SecondPhotoId = guitars[i].SecondPhotoId,
                    ThirdPhotoId = guitars[i].ThirdPhotoId,
                    MainPhoto = GetPhoto(guitars[i].MainPhotoId),
                    SecondPhoto = GetPhoto(guitars[i].SecondPhotoId),
                    ThirdPhoto = GetPhoto(guitars[i].ThirdPhotoId),
                    CharacteristicPhoto = GetPhoto(guitars[i].CharacteristicPhotoId)
                });

            return dto;
        }
        private byte[] GetPhoto(int id)
        {
            ImageSiteDTO imageSiteDTO = imageSiteService.Get(id);
            return imageSiteDTO.Photo;
        }
        public GuitarDTO Get(int goodId)
        {
            Guitar guitar = Repository.Get(goodId);
            GuitarDTO imageSiteDTO = mapper.Map<Guitar, GuitarDTO>(guitar);
            imageSiteDTO.MainPhoto = GetPhoto(guitar.MainPhotoId);
            imageSiteDTO.SecondPhoto = GetPhoto(guitar.SecondPhotoId);
            imageSiteDTO.ThirdPhoto = GetPhoto(guitar.ThirdPhotoId);
            imageSiteDTO.CharacteristicPhoto = GetPhoto(guitar.CharacteristicPhotoId);
            return imageSiteDTO;
        }
        public Guitar GetRep(int goodId)
        {
            return Repository.Get(goodId); ;
        }

        public GuitarDTO Delete(GuitarDTO goodDto)
        {
            Guitar goodToRemove = Repository.Get(goodDto.GuitarId);
            Repository.Delete(goodToRemove);
            Repository.SaveChanges();
            return goodDto;
        }

        public void CreateOrUpdate(GuitarDTO goodDto)
        {
            Guitar good = mapper.Map<GuitarDTO, Guitar>(goodDto);
            Repository.CreateOrUpdate(good);
            Repository.SaveChanges();
        }
    }
}
