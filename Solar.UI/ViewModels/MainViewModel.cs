using Solar.BLL.DTO;
using Solar.BLL.Services;
using Solar.DAL.Context;
using Solar.DAL.Repositories;
using Solar.UI.Infrastructure;
using Solar.UI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Solar.UI.ViewModels
{
    public class MainViewModel : BaseNotifyPropertyChanged, INavigate
    {
        public UserDTO SignedUser { get; set; }
        public ImageSiteService imageSiteService { get; set; } = new ImageSiteService(new ImageSiteRepository(new SiteContext()));

        public string num;
        public string Num
        {
            get => num;
            set
            {
                num = value;
                NotifyOfPopertyChanged();
            }
        }

        private BitmapImage logo;
        public BitmapImage Logo
        {
            get => logo;
            set
            {
                logo = value;
                NotifyOfPopertyChanged();
            }
        }

        private BitmapImage shipBasket;
        public BitmapImage ShipBasket
        {
            get => shipBasket;
            set
            {
                shipBasket = value;
                NotifyOfPopertyChanged();
            }
        }

        private BitmapImage account;
        public BitmapImage Account
        {
            get => account;
            set
            {
                account = value;
                NotifyOfPopertyChanged();
            }
        }


        private UserControl contentControl;
        public UserControl ContentControl
        {
            get => contentControl;
            set
            {
                contentControl = value;
                NotifyOfPopertyChanged();
            }

        }
        GuitarService GuitarService = new GuitarService(new GuitarRepository(new SiteContext()));
        public MainViewModel()
        {
            Bridge.ViewModel = this;
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(ShipBasket).TypeHandle);
            Num = "0";
            Logo = new BitmapImage();
            Account = new BitmapImage();
            ShipBasket = new BitmapImage();
            Infrastructure.ShipBasket.Refresh();
            Filler f = new Filler();
            f.Fill();
            Thread t = new Thread(() =>
            {
                Logo.Dispatcher.InvokeAsync(new Action(() =>
                {
                    ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.Logo);
                    BitmapImage i = new BitmapImage();
                    i.BeginInit();
                    i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                    i.EndInit();
                    Logo = i;
                }));
                Account.Dispatcher.InvokeAsync(new Action(() =>
                {
                    ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.accountButton);
                    BitmapImage i = new BitmapImage();
                    i.BeginInit();
                    i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                    i.EndInit();
                    Account = i;
                }));
                ShipBasket.Dispatcher.InvokeAsync(new Action(() =>
                {
                    ImageSiteDTO imageSiteDTO = imageSiteService.Get((int)IDImage.shipbasketButton);
                    BitmapImage i = new BitmapImage();
                    i.BeginInit();
                    i.StreamSource = new MemoryStream(imageSiteDTO.Photo);
                    i.EndInit();
                    ShipBasket = i;
                }));
            });
            t.Start();
            Switcher.ContentArea = this;
            FillCmd();
            Task.Run(() => { GuitarsPageViewModel.GuitarDTOs = new ObservableCollection<GuitarDTO>(GuitarService.GetAll()); });
            Switcher.Switch(new MainPageView());
        }
        public void FillCmd()
        {
            CommandMain = new RelayCommand(param =>
            {
                Switcher.Switch(new MainPageView());
            });
            CommandGuitar = new RelayCommand(param =>
            {
                Switcher.Switch(new GuitarsMainPageView());
            });
            CommandContact = new RelayCommand(param =>
            {
                Switcher.Switch(new ContactUsPageView());
            });
            CommandAbout = new RelayCommand(param =>
            {
                Switcher.Switch(new AboutUsPageView());
            });
            CommandShipBasket = new RelayCommand(param =>
            {
                ShipBasketPageView d = new ShipBasketPageView();
                Switcher.Switch(d);
            });
            CommandAccount = new RelayCommand(param =>
            {
                Switcher.Switch(new MainAccountPageView());
            });

        }

        public void SetNum(string s)
        {
            Num = s;
        }
        public void Navigate(UserControl page)
        {
            ContentControl = page;
        }

        public ICommand CommandMain { get; set; }
        public ICommand CommandGuitar { get; set; }
        public ICommand CommandContact { get; set; }
        public ICommand CommandAbout { get; set; }
        public ICommand CommandAccount { get; set; }
        public ICommand CommandShipBasket { get; set; }

    }
}
