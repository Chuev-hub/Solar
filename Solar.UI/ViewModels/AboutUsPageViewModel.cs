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
using System.Windows.Media.Imaging;

namespace Solar.UI.ViewModels
{
    public class AboutUsPageViewModel : BaseNotifyPropertyChanged
    {
        public ImageSiteService imageSiteService { get; set; } = new ImageSiteService(new ImageSiteRepository(new SiteContext()));

        public BitmapImage manImage;
        public BitmapImage ManImage
        {
            get => manImage;
            set
            {
                manImage = value;
                NotifyOfPopertyChanged();
            }
        }
        public BitmapImage signImage;
        public BitmapImage SignImage
        {
            get => signImage;
            set
            {
                signImage = value;
                NotifyOfPopertyChanged();
            }
        }
        public AboutUsPageViewModel()
        {
            ManImage = new BitmapImage();
            SignImage = new BitmapImage();
            Thread t = new Thread(() => {
                ManImage.Dispatcher.InvokeAsync(new Action(() =>
                {
                    ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.AboutUsMainMan);
                    BitmapImage i = new BitmapImage();
                    i.BeginInit();
                    i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                    i.EndInit();
                    ManImage = i;
                }));
                SignImage.Dispatcher.InvokeAsync(new Action(() =>
                {
                    ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.SignOfMan);
                    BitmapImage i = new BitmapImage();
                    i.BeginInit();
                    i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                    i.EndInit();
                    SignImage = i;
                }));
            });
            t.Start();
        }
    }
}