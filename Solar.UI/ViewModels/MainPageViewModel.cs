using Solar.BLL.DTO;
using Solar.BLL.Services;
using Solar.DAL.Context;
using Solar.DAL.Repositories;
using Solar.UI.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Solar.UI.ViewModels
{
    public class MainPageViewModel : BaseNotifyPropertyChanged
    {
        public ImageSiteService imageSiteService { get; set; } = new ImageSiteService(new ImageSiteRepository(new SiteContext()));

        public BitmapImage main;
        public BitmapImage Main
        {
            get => main;
            set
            {
                main = value;
                NotifyOfPopertyChanged();
            }
        }
        public BitmapImage news1;
        public BitmapImage News1
        {
            get => news1;
            set
            {
                news1 = value;
                NotifyOfPopertyChanged();
            }
        }
        public BitmapImage news2;
        public BitmapImage News2
        {
            get => news2;
            set
            {
                news2 = value;
                NotifyOfPopertyChanged();
            }
        }
        public BitmapImage news3;
        public BitmapImage News3
        {
            get => news3;
            set
            {
                news3 = value;
                NotifyOfPopertyChanged();
            }
        }
        public BitmapImage smallLogo;
        public BitmapImage SmallLogo
        {
            get => smallLogo;
            set
            {
                smallLogo = value;
                NotifyOfPopertyChanged();
            }
        }
        public BitmapImage Main1 { get; set; } = new BitmapImage();
        public BitmapImage Main2 { get; set; } = new BitmapImage();
        public BitmapImage Main3 { get; set; } = new BitmapImage();
        public BitmapImage Main4 { get; set; } = new BitmapImage();
        public List< BitmapImage> Mains { get; set; } = new List<BitmapImage>();
      
        public ICommand FirstImageCommand { get; set; }
        public ICommand SecondImageCommand { get; set; }
        public ICommand ThirdImageCommand { get; set; }
        public ICommand FourthImageCommand { get; set; }
        public MainPageViewModel()
        {
            Visibilitys = Visibility.Hidden;
            Main = new BitmapImage();
            News1 = new BitmapImage();
            News2 = new BitmapImage();
            News3 = new BitmapImage();
            SmallLogo = new BitmapImage();

            InitCmd();
            InitPh();
           
            
            
        }
        int i = 0;
        public Visibility visibility;
        public Visibility Visibilitys{ get => visibility; set { visibility = value;
                NotifyOfPopertyChanged();
            } }
        void InitCmd()
        {
            backPh = new RelayCommand(param =>
            {

                int max = Mains.Count;
                if (i == 0)
                    i = Mains.Count - 1;
                else i--;
                Main = Mains[i];
            });
            nextPh = new RelayCommand(param =>
            {
                int max = Mains.Count;
                if (i == Mains.Count - 1)
                    i = 0;
                else
                    i++;
                Main = Mains[i];
            });
          
        }
        void InitPh()
        {
           
            Thread t = new Thread(() => {
                Main1.Dispatcher.InvokeAsync(new Action(() =>
                {
                    ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.MainPhoto1);
                    BitmapImage i = new BitmapImage();
                    i.BeginInit();
                    i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                    i.EndInit();
                    Main1 = i;Main = Main1;
                    Mains.Add(Main1);
                    if(Mains.Count==4)
                        Visibilitys = Visibility.Visible;
                }));
                Main2.Dispatcher.InvokeAsync(new Action(() =>
                {
                    ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.MainPhoto2);
                    BitmapImage i = new BitmapImage();
                    i.BeginInit();
                    i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                    i.EndInit();
                    Main2 = i;
                    Mains.Add(Main2);
                    if (Mains.Count == 4)
                        Visibilitys = Visibility.Visible;
                }));
                Main3.Dispatcher.InvokeAsync(new Action(() =>
                {
                    ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.MainPhoto3);
                    BitmapImage i = new BitmapImage();
                    i.BeginInit();
                    i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                    i.EndInit();
                    Main3 = i;
                    Mains.Add(Main3);
                    if (Mains.Count == 4)
                        Visibilitys = Visibility.Visible;
                }));
                Main4.Dispatcher.InvokeAsync(new Action(() =>
                {
                    ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.MainPhoto4);
                    BitmapImage i = new BitmapImage();
                    i.BeginInit();
                    i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                    i.EndInit();
                    Main4 = i;
                    Mains.Add(Main4);
                    if (Mains.Count == 4)
                        Visibilitys = Visibility.Visible;
                }));
                News1.Dispatcher.InvokeAsync(new Action(() =>
                {
                    ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.MainPhotoNews1);
                    BitmapImage i = new BitmapImage();
                    i.BeginInit();
                    i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                    i.EndInit();
                    News1 = i;
                }));
                News2.Dispatcher.InvokeAsync(new Action(() =>
                {
                    ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.MainPhotoNews2);
                    BitmapImage i = new BitmapImage();
                    i.BeginInit();
                    i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                    i.EndInit();
                    News2 = i;
                }));
                News3.Dispatcher.InvokeAsync(new Action(() =>
                {
                    ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.MainPhotoNews3);
                    BitmapImage i = new BitmapImage();
                    i.BeginInit();
                    i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                    i.EndInit();
                    News3 = i;
                }));
                SmallLogo.Dispatcher.InvokeAsync(new Action(() =>
                {
                    ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.SmallLogo);
                    BitmapImage i = new BitmapImage();
                    i.BeginInit();
                    i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                    i.EndInit();
                    SmallLogo = i;

                }));
                
            });
            t.Start();
           
        }
         public ICommand backPh { get; set; }
        public ICommand nextPh { get; set; }
        
    }
}
