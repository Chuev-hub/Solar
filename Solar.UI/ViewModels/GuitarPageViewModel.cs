using Solar.BLL.DTO;
using Solar.UI.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Solar.UI.ViewModels
{
    public class GuitarPageViewModel:BaseNotifyPropertyChanged
    {
        public GuitarsMainPageViewModel GuitarsMainPageViewModel { get; set; }
        public byte[] main;
        public byte[] Main
        {
            get => main;
            set
            {
                main = value;
                NotifyOfPopertyChanged();
            }
        }
        private GuitarDTO currentGuitar;
        public GuitarDTO CurrentGuitar
        {
            get => currentGuitar;
            set
            {
                currentGuitar = value;
                NotifyOfPopertyChanged();
            }
        }
        public GuitarPageViewModel()
        {
          
            BackCommand = new RelayCommand(x =>
            {
                GuitarsMainPageViewModel.Navigate(GuitarsMainPageViewModel.GuitarsPage);
            });
            MainCommand = new RelayCommand(x =>
            {
                Main = CurrentGuitar.MainPhoto;
            });
            SecondCommand = new RelayCommand(x =>
            {
                Main = CurrentGuitar.SecondPhoto;
            });
            ThirdCommand = new RelayCommand(x =>
            {
                Main = CurrentGuitar.ThirdPhoto;
            });
            BuyCommand = new RelayCommand(x =>
            {
                ShipBasket.Products.Add(CurrentGuitar);
                
                ShipBasket.Save();
                
                ShipBasket.Refresh();

                
            });
        }
        public ICommand BackCommand { set; get; }
        public ICommand MainCommand { set; get; }
        public ICommand SecondCommand { set; get; }
        public ICommand ThirdCommand { set; get; }
        public ICommand BuyCommand { set; get; }
        
        public void fillPhoto()
        {
            Main = CurrentGuitar.MainPhoto;
        }
    }
}
