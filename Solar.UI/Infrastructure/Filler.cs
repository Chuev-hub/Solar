using Solar.BLL.DTO;
using Solar.BLL.Services;
using Solar.DAL.Context;
using Solar.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Solar.UI.Infrastructure
{
    class Filler
    {
        public ImageSiteService imageSiteService { get; set; } = new ImageSiteService(new ImageSiteRepository(new SiteContext()));
        SiteContext SiteContext = new SiteContext();
        IRepository<Admin> adminRepository;
        IRepository<Guitar> guitarRepository;
        IRepository<GuitarCategory> guitarCategoryRepository;
        IRepository<ImageSite> imageSiteRepository;
        IRepository<Order> orderRepository;
        IRepository<ProductOrder> productOrderRepository;
        IRepository<User> userRepository;
        private byte[] GetPhoto(int id)
        {

            ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.SmallLogo);
            BitmapImage i = new BitmapImage();
            i.BeginInit();
            i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
            i.EndInit();

            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(i));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }
        byte[] RefreshImage(byte[] array)
        {
            Bitmap bitmap = new Bitmap(GetImageFromeByteArray(array));
            return ImageToBytes(bitmap);
        }
        Image GetImageFromeByteArray(byte[] array)
        {
            using (MemoryStream ms = new MemoryStream(array))
            {
                return Image.FromStream(ms);
            }
        }
        byte[] ImageToBytes(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        public void Fill()
        {
          
            adminRepository = new AdminRepository(SiteContext);
            guitarRepository = new GuitarRepository(SiteContext);
            guitarCategoryRepository = new GuitarCategoryRepository(SiteContext);
            imageSiteRepository = new ImageSiteRepository(SiteContext);
            orderRepository = new DAL.Repositories.OrderRepository(SiteContext);
            productOrderRepository = new ProductOrderRepository(SiteContext);
            userRepository = new UserRepository(SiteContext);
            if (imageSiteRepository.GetAll().Count() != 0)
                return;
            adminRepository.CreateOrUpdate(new Admin() { Login = "admin", Password = "admin".GetHashCode().ToString() });
            adminRepository.SaveChanges();

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\main1.jpg") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\main2.jpg") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\main3.jpg") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\main4.jpg") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\new1.jpg") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\new2.jpg") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\new3.jpeg") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\logo.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\ola-logo.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\Ola.jpeg") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\sign.jpg") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\cab.jpg") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\korz.jpg") });

            //ab
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_First_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_First_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_First_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_First_4.png") });


            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Second_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Second_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Second_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Second_4.png") });

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Third_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Third_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Third_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Third_4.png") });

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Fourth_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Fourth_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Fourth_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Fourth_4.png") });

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Fifth_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Fifth_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Fifth_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\AB_Fifth_4.png") });
            ////   


            //E
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_First_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_First_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_First_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_First_4.png") });


            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Second_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Second_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Second_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Second_4.png") });

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Third_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Third_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Third_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Third_4.png") });

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Fourth_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Fourth_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Fourth_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Fourth_4.png") });

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Fifth_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Fifth_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Fifth_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\E_Fifth_4.png") });

            ////


            //V

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_First_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_First_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_First_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_First_4.png") });


            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Second_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Second_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Second_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Second_4.png") });
            
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Third_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Third_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Third_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Third_4.png") });

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Fourth_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Fourth_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Fourth_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Fourth_4.png") });

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Fifth_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Fifth_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Fifth_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\V_Fifth_4.png") });
            ////


            //G

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_First_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_First_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_First_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_First_4.png") });


            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Second_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Second_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Second_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Second_4.png") });

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Third_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Third_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Third_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Third_4.png") });

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Fourth_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Fourth_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Fourth_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Fourth_4.png") });

            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Fifth_1.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Fifth_2.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Fifth_3.png") });
            imageSiteRepository.CreateOrUpdate(new ImageSite() { Photo = File.ReadAllBytes("Images\\G_Fifth_4.png") });
            ////









            imageSiteRepository.SaveChanges();

            guitarCategoryRepository.CreateOrUpdate(new GuitarCategory() { Name = "AB" });
            guitarCategoryRepository.CreateOrUpdate(new GuitarCategory() { Name = "E" });
            guitarCategoryRepository.CreateOrUpdate(new GuitarCategory() { Name = "V" });
            guitarCategoryRepository.CreateOrUpdate(new GuitarCategory() { Name = "G" });

            guitarCategoryRepository.SaveChanges();


            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "AB1.6S",
                Price = 999,
                GuitarCategoryId = 1,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "White Silver",
                LeftHanded = "NO",
                Material = "ROASTED MAPLE",
                Middle = "NO",
                Neck = "DUNCAN SOLAR DUAL RAIL",
                Shape = "TYPE AB",
                Switch = "3-WAY BLADE",
                NumberOfStrings = "6",
                Info = " Created with the most demanding guitarists in mind, this premium feature - loaded bolt - on guitar belongs to the Solar Type AB1 top of the line range, offering outstanding elegance and performance. ",
                MainPhotoId = (int)IDImage.ABFIRST1,
                SecondPhotoId = (int)IDImage.ABFIRST2,
                ThirdPhotoId = (int)IDImage.ABFIRST3,
                CharacteristicPhotoId = (int)IDImage.ABFIRST4
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "AB1.6G",
                GuitarCategoryId = 1,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Price = 999,
                Color = "Yellow",
                LeftHanded = "NO",
                Material = "ROASTED MAPLE",
                Middle = "NO",
                Neck = "DUNCAN SOLAR DUAL RAIL",
                Shape = "TYPE AB",
                Switch = "3-WAY BLADE",
                NumberOfStrings = "6",
                Info = "Created with the most demanding guitarists in mind, this premium feature - loaded bolt - on guitar belongs to the Solar Type AB1 top of the line range, offering outstanding elegance and performance. ",
                MainPhotoId = ((int)IDImage.ABSECOND1),
                SecondPhotoId = ((int)IDImage.ABSECOND2),
                ThirdPhotoId = ((int)IDImage.ABSECOND3),
                CharacteristicPhotoId = ((int)IDImage.ABSECOND4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "AB1.6FRCAR",
                GuitarCategoryId = 1,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Price = 899,
                Color = "CANDY APPLE RED",
                LeftHanded = "NO",
                Material = "ROASTED MAPLE",
                Middle = "NO",
                Neck = "DUNCAN SOLAR DUAL RAIL",
                Shape = "TYPE AB",
                Switch = "3-WAY BLADE",
                NumberOfStrings = "6",
                Info = "Created with the most demanding guitarists in mind, this premium feature - loaded bolt - on guitar belongs to the Solar Type AB1 top of the line range, offering outstanding elegance and performance. ",
                MainPhotoId = ((int)IDImage.ABTHIRD1),
                SecondPhotoId = ((int)IDImage.ABTHIRD2),
                ThirdPhotoId = ((int)IDImage.ABTHIRD3),
                CharacteristicPhotoId = ((int)IDImage.ABTHIRD4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "AB1.6FRNB",
                GuitarCategoryId = 1,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "NATURAL BROWN",
                LeftHanded = "NO",
                Material = "ROASTED MAPLE",
                Middle = "NO",
                Neck = "DUNCAN SOLAR DUAL RAIL",
                Shape = "TYPE AB",
                Switch = "3-WAY BLADE",
                NumberOfStrings = "6",
                Info = "Created with the most demanding guitarists in mind, this premium feature - loaded bolt - on guitar belongs to the Solar Type AB1 top of the line range, offering outstanding elegance and performance. ",
                Price = 949,
                MainPhotoId = ((int)IDImage.ABFOURTH1),
                SecondPhotoId = ((int)IDImage.ABFOURTH2),
                ThirdPhotoId = ((int)IDImage.ABFOURTH3),
                CharacteristicPhotoId = ((int)IDImage.ABFOURTH4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "AB1.7W",
                GuitarCategoryId = 1,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "WHITE MATTE",
                LeftHanded = "NO",
                Material = "ROASTED MAPLE",
                Middle = "NO",
                Neck = "DUNCAN SOLAR DUAL RAIL",
                Shape = "TYPE AB",
                Switch = "3-WAY BLADE",
                Price = 1099,
                NumberOfStrings = "7",
                Info = "Created with the most demanding guitarists in mind, this premium feature - loaded bolt - on guitar belongs to the Solar Type AB1 top of the line range, offering outstanding elegance and performance. ",
                MainPhotoId = ((int)IDImage.ABFIFTH1),
                SecondPhotoId = ((int)IDImage.ABFIFTH2),
                ThirdPhotoId = ((int)IDImage.ABFIFTH3),
                CharacteristicPhotoId = ((int)IDImage.ABFIFTH4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "E1.7FBB",
                GuitarCategoryId = 2,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "BLOOD RED OPEN PORE W BLOOD SPLATTER",
                LeftHanded = "NO",
                Material = "MAPLE",
                Middle = "NO",
                Price = 1300,
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE E",
                Switch = "3-WAY TOGGLE",
                NumberOfStrings = "7",
                Info = "This revolutionary, feature-loaded and top of the line Solar Type E1 range guitar was created with a radical passion for design and an expert attention to detail.n",
                MainPhotoId = ((int)IDImage.EFIRST1),
                SecondPhotoId = ((int)IDImage.EFIRST2),
                ThirdPhotoId = ((int)IDImage.EFIRST3),
                CharacteristicPhotoId = ((int)IDImage.EFIRST4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "E1.6",
                GuitarCategoryId = 2,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "WHITE MATTE (W)",
                LeftHanded = "NO",
                Material = "MAPLE",
                Middle = "NO",
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE E",
                Price = 1099,
                Switch = "3-WAY TOGGLE",
                NumberOfStrings = "6",
                Info = "Created together with Texan guitarist and producer Marzi Montazeri (aka “The High Priest of Distortion”), this revolutionary feature-loaded and top of the line Solar Type E1 Artist guitar called “The Priestess” was created with a radical passion for design and an expert attention to detail. NOTE: THE E1.6 PRIESTESS DOES NOT FIT IN OUR TYPE E HARDCASE",
                MainPhotoId = ((int)IDImage.ESECOND1),
                SecondPhotoId = ((int)IDImage.ESECOND2),
                ThirdPhotoId = ((int)IDImage.ESECOND3),
                CharacteristicPhotoId = ((int)IDImage.ESECOND4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "E1.6FRLB",
                GuitarCategoryId = 2,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "FLAME LIME BURST MATTE (LB)",
                LeftHanded = "NO",
                Material = "MAPLE",
                Middle = "NO",
                Price = 999,
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE E",
                Switch = "3-WAY TOGGLE",
                NumberOfStrings = "6",
                Info = "Created together with Texan guitarist and producer Marzi Montazeri (aka “The High Priest of Distortion”), this revolutionary feature-loaded and top of the line Solar Type E1 Artist guitar called “The Priestess” was created with a radical passion for design and an expert attention to detail. NOTE: THE E1.6 PRIESTESS DOES NOT FIT IN OUR TYPE E HARDCASE",
                MainPhotoId = ((int)IDImage.ETHIRD1),
                SecondPhotoId = ((int)IDImage.ETHIRD2),
                ThirdPhotoId = ((int)IDImage.ETHIRD3),
                CharacteristicPhotoId = ((int)IDImage.ETHIRD4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "E2.6BOP",
                GuitarCategoryId = 2,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "BLACK OPEN PORE",
                LeftHanded = "NO",
                Material = "MAPLE",
                Middle = "NO",
                Price = 799,
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE E",
                Switch = "3-WAY TOGGLE",
                NumberOfStrings = "6",
                Info = "Created together with Texan guitarist and producer Marzi Montazeri (aka “The High Priest of Distortion”), this revolutionary feature-loaded and top of the line Solar Type E1 Artist guitar called “The Priestess” was created with a radical passion for design and an expert attention to detail. NOTE: THE E1.6 PRIESTESS DOES NOT FIT IN OUR TYPE E HARDCASE",
                MainPhotoId = ((int)IDImage.EFOURTH1),
                SecondPhotoId = ((int)IDImage.EFOURTH2),
                ThirdPhotoId = ((int)IDImage.EFOURTH3),
                CharacteristicPhotoId = ((int)IDImage.EFOURTH4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "E2.6C",
                GuitarCategoryId = 2,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "CARBON BLACK MATTE",
                LeftHanded = "NO",
                Material = "MAPLE",
                Middle = "NO",
                Price = 749,
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE E",
                Switch = "3-WAY TOGGLE",
                NumberOfStrings = "6",
                Info = "Created together with Texan guitarist and producer Marzi Montazeri (aka “The High Priest of Distortion”), this revolutionary feature-loaded and top of the line Solar Type E1 Artist guitar called “The Priestess” was created with a radical passion for design and an expert attention to detail. NOTE: THE E1.6 PRIESTESS DOES NOT FIT IN OUR TYPE E HARDCASE",
                MainPhotoId = ((int)IDImage.EFIFTH1),
                SecondPhotoId = ((int)IDImage.EFIFTH2),
                ThirdPhotoId = ((int)IDImage.EFIFTH3),
                CharacteristicPhotoId = ((int)IDImage.EFIFTH4)
            });



            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "V1.8C",
                GuitarCategoryId = 3,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Price = 1299,
                Color = "CARBON BLACK MATT",
                LeftHanded = "NO",
                Material = "MAPLE",
                Middle = "NO",
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE V",
                Switch = "3-WAY TOGGLE",
                NumberOfStrings = "8",
                Info = "This premium feature-loaded eight-string guitar belongs to the Solar Type V1 top of the line range, offering outstanding elegance and performance. NOTE: THIS GUITAR DOES NOT FIT INSIDE THE SOLAR HARDCASE V",
                MainPhotoId = ((int)IDImage.VFIRST1),
                SecondPhotoId = ((int)IDImage.VFIRST2),
                ThirdPhotoId = ((int)IDImage.VFIRST3),
                CharacteristicPhotoId = ((int)IDImage.VFIRST4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "V1.7D LTD",
                GuitarCategoryId = 3,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "AGED NATURAL MATTE",
                LeftHanded = "NO",
                Material = "MAPLE",
                Middle = "NO",
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE V",
                Price = 1299,
                Switch = "3-WAY TOGGLE",
                NumberOfStrings = "7",
                Info = "This premium feature-loaded eight-string guitar belongs to the Solar Type V1 top of the line range, offering outstanding elegance and performance. NOTE: THIS GUITAR DOES NOT FIT INSIDE THE SOLAR HARDCASE V",
                MainPhotoId = ((int)IDImage.VSECOND1),
                SecondPhotoId = ((int)IDImage.VSECOND2),
                ThirdPhotoId = ((int)IDImage.VSECOND3),
                CharacteristicPhotoId = ((int)IDImage.VSECOND4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "V2.6MDS",
                GuitarCategoryId = 3,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "METALLIC DARK SILVER",
                LeftHanded = "NO",
                Material = "MAPLE",
                Middle = "NO",
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE V",
                Price = 749,
                Switch = "3-WAY TOGGLE",
                NumberOfStrings = "6",
                Info = "This premium feature-loaded eight-string guitar belongs to the Solar Type V1 top of the line range, offering outstanding elegance and performance. NOTE: THIS GUITAR DOES NOT FIT INSIDE THE SOLAR HARDCASE V",
                MainPhotoId = ((int)IDImage.VTHIRD1),
                SecondPhotoId = ((int)IDImage.VTHIRD2),
                ThirdPhotoId = ((int)IDImage.VTHIRD3),
                CharacteristicPhotoId = ((int)IDImage.VTHIRD4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "V2.6TBR SK",
                GuitarCategoryId = 3,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "TRANS BLOOD RED MATTE",
                LeftHanded = "NO",
                Material = "MAPLE",
                Middle = "NO",
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE V",
                Price = 799,
                Switch = "3-WAY TOGGLE",
                NumberOfStrings = "6",
                Info = "This premium feature-loaded eight-string guitar belongs to the Solar Type V1 top of the line range, offering outstanding elegance and performance. NOTE: THIS GUITAR DOES NOT FIT INSIDE THE SOLAR HARDCASE V",
                MainPhotoId = ((int)IDImage.VFOURTH1),
                SecondPhotoId = ((int)IDImage.VFOURTH2),
                ThirdPhotoId = ((int)IDImage.VFOURTH3),
                CharacteristicPhotoId = ((int)IDImage.VFOURTH4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {

                Name = "V2.6AG",
                GuitarCategoryId = 3,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "ARMY GREEN MATTE (AG)",
                LeftHanded = "NO",
                Material = "MAPLE",
                Middle = "NO",
                Neck = "NO",
                Shape = "TYPE V",
                Switch = "NO",
                Price = 699,
                NumberOfStrings = "6",
                Info = "Unique with its menacing looks, this affordable and feature-loaded guitar belongs to the Solar Type V2 range, offering outstanding elegance and performance",

                MainPhotoId = ((int)IDImage.VFIFTH1),
                SecondPhotoId = ((int)IDImage.VFIFTH2),
                ThirdPhotoId = ((int)IDImage.VFIFTH3),
                CharacteristicPhotoId = ((int)IDImage.VFIFTH4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "GC1.7FBB",
                GuitarCategoryId = 4,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "FLAME BLACK BURST MATTE",
                LeftHanded = "NO",
                Material = "MAPLE",
                Middle = "NO",
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE G",
                Switch = "3-WAY TOGGLE",
                Price = 1299,
                NumberOfStrings = "7",
                Info = " Unique with its modern, stealthy looks and 7 inline reversed headstock, this premium feature-loaded single cutaway guitar belongs to the Solar Type G1 range, offering outstanding elegance and performance.n",
                MainPhotoId = ((int)IDImage.GFIRST1),
                SecondPhotoId = ((int)IDImage.GFIRST2),
                ThirdPhotoId = ((int)IDImage.GFIRST3),
                CharacteristicPhotoId = ((int)IDImage.GFIRST4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "GC1.6B",
                GuitarCategoryId = 4,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "BLACK GLOSS",
                LeftHanded = "NO",
                Material = "MAPLE",
                Middle = "NO",
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE G",
                Switch = "3-WAY TOGGLE",
                Price = 1099,
                NumberOfStrings = "6",
                Info = " Unique with its modern, stealthy looks and 7 inline reversed headstock, this premium feature-loaded single cutaway guitar belongs to the Solar Type G1 range, offering outstanding elegance and performance.n",
                MainPhotoId = ((int)IDImage.GSECOND1),
                SecondPhotoId = ((int)IDImage.GSECOND2),
                ThirdPhotoId = ((int)IDImage.GSECOND3),
                CharacteristicPhotoId = ((int)IDImage.GSECOND4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "GC1.6FAB",
                GuitarCategoryId = 4,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "FLAME SOLAR AMBER BURST",
                LeftHanded = "NO",
                Material = "MAHOGANY",
                Middle = "NO",
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE G",
                Switch = "3-WAY TOGGLE",
                Price = 1099,
                NumberOfStrings = "6",
                Info = " Unique with its modern, stealthy looks and 7 inline reversed headstock, this premium feature-loaded single cutaway guitar belongs to the Solar Type G1 range, offering outstanding elegance and performance.n",
                MainPhotoId = ((int)IDImage.GTHIRD1),
                SecondPhotoId = ((int)IDImage.GTHIRD2),
                ThirdPhotoId = ((int)IDImage.GTHIRD3),
                CharacteristicPhotoId = ((int)IDImage.GTHIRD4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "GC1.6FAB",
                GuitarCategoryId = 4,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "CARBON BLACK MATTE",
                LeftHanded = "NO",
                Material = "MAHOGANY",
                Middle = "NO",
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE G",
                Switch = "3-WAY TOGGLE",
                Price = 649,
                NumberOfStrings = "6",
                Info = " Unique with its modern, stealthy looks and 7 inline reversed headstock, this premium feature-loaded single cutaway guitar belongs to the Solar Type G1 range, offering outstanding elegance and performance.n",
                MainPhotoId = ((int)IDImage.GFOURTH1),
                SecondPhotoId = ((int)IDImage.GFOURTH2),
                ThirdPhotoId = ((int)IDImage.GFOURTH3),
                CharacteristicPhotoId = ((int)IDImage.GFOURTH4)
            });
            guitarRepository.CreateOrUpdate(new Guitar()
            {
                Name = "GC1.6FAB",
                GuitarCategoryId = 4,
                Bridge = "DUNCAN SOLAR/BRIDGE",
                Color = "FLAME BLACK GLOSS",
                LeftHanded = "NO",
                Material = "MAHOGANY",
                Middle = "NO",
                Neck = "DUNCAN SOLAR",
                Shape = "TYPE G",
                Switch = "3-WAY TOGGLE",
                Price = 1199,
                NumberOfStrings = "6",
                Info = "Created together with Texan guitarist and tone connoisseur Jason “Killertone” Frankhouser , this premium feature-loaded single cutaway guitar belongs to the Solar Type G1 range, offering outstanding elegance and performance. NOTE: Picture shows prototype. Production models has pickups with black gloss bobbin, black nickel screws and slugs and silver Seymour Duncan logo",
                MainPhotoId = ((int)IDImage.GFIFTH1),
                SecondPhotoId = ((int)IDImage.GFIFTH2),
                ThirdPhotoId = ((int)IDImage.GFIFTH3),
                CharacteristicPhotoId = ((int)IDImage.GFIFTH4)
            });

            guitarRepository.SaveChanges();
        }
    }
}