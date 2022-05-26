using GalaSoft.MvvmLight.Command;
using Solar.BLL.DTO;
using Solar.BLL.Services;
using Solar.DAL.Context;
using Solar.DAL.Repositories;
using Solar.UI.Infrastructure;
using Solar.UI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Solar.UI.ViewModels
{
    public class AccountPageViewModel : BaseNotifyPropertyChanged
    {
        ProductOrderService ProductOrderService = new ProductOrderService(new ProductOrderRepository(new SiteContext()));
        UserService service = new UserService(new UserRepository(new SiteContext()));
        public ObservableCollection<GuitarDTO> guitars;
        public ObservableCollection<GuitarDTO> Guitars
        {
            get
            {
                return guitars;
            }
            set
            {
                guitars = value;
                NotifyOfPopertyChanged();
            }
        }
        bool IsChecked;
        public OrderDTO selectedOrder;
        public OrderDTO SelectedOrder
        {
            get => selectedOrder;
            set
            {
                selectedOrder = value;
                try
                {
                    Guitars = new ObservableCollection<GuitarDTO>(ProductOrderService.GetAll().Where(d => d.OrderId == SelectedOrder.OrderId).Select(x => x.Guitar));
                }
                catch
                {
                    Guitars = new ObservableCollection<GuitarDTO>();
                }
                NotifyOfPopertyChanged();
            }

        }
        public UserDTO userDTO;
        public UserDTO UserDTO
        {
            get => userDTO;
            set
            {
                userDTO = value;
                NotifyOfPopertyChanged();
            }

        }
        public string exc;
        public string Exc
        {
            get => exc;
            set
            {
                exc = value;
                NotifyOfPopertyChanged();
            }

        }
        public string elipseColor;
        public string ElipseColor
        {
            get => elipseColor;
            set
            {
                elipseColor = value;
                NotifyOfPopertyChanged();
            }

        }
        public string address;
        public string Address
        {
            get => address;
            set
            {
                address = value;
                NotifyOfPopertyChanged();
            }

        }
        public string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                NotifyOfPopertyChanged();
            }

        }
        public string surname;
        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
                NotifyOfPopertyChanged();
            }

        }

        public ICommand LogoutCmd { get; set; }
        public ICommand SaveCmd { get => new RelayCommand<object>(Save); }
        public ICommand CheckCmd { get => new RelayCommand<object>(Check); }
        public AccountPageViewModel()
        {
            ElipseColor = "Red";

            LogoutCmd = new Infrastructure.RelayCommand(x =>
            {
                try
                {
                    ShipBasket.Save();
                }
                catch { }
                ShipBasket.Products = new ObservableCollection<GuitarDTO>();
                ShipBasket.Refresh();
                Bridge.ViewModel.SignedUser = null;
                Switcher.Switch(new MainAccountPageView());
            });
            UserDTO = Bridge.ViewModel.SignedUser;
            try
            {
                ShipBasket.Upload(UserDTO.UserId);
            }
            catch { }
        }

        string oldpsw { get; set; }
        private void Check(object o)
        {
            oldpsw = (o as PasswordBox).Password;
            if (oldpsw.GetHashCode().ToString() == userDTO.Password)
            {
                IsChecked = true;
                ElipseColor = "Green";
            }
            else
            {
                IsChecked = false;
                ElipseColor = "Red";
            }

        }
        private void Save(object o)
        {
            Exc = "";
            Bridge.ViewModel.SignedUser.Address = UserDTO.Address;
            Bridge.ViewModel.SignedUser.Name = UserDTO.Name;
            Bridge.ViewModel.SignedUser.SurName = UserDTO.SurName;
            if (IsChecked)
                Bridge.ViewModel.SignedUser.Password = (o as PasswordBox).Password.GetHashCode().ToString();
            else
            {
                if ((o as PasswordBox).Password != "")
                    Exc = "Check password";
            }

            //Bridge.ViewModel.SignedUser. =;
            //Bridge.ViewModel.SignedUser. =;
            //Bridge.ViewModel.SignedUser. =;              ORDERRRRRRRRS
            //Bridge.ViewModel.SignedUser. =;
            //Bridge.ViewModel.SignedUser. =;
            //Bridge.ViewModel.SignedUser. =;
            //Bridge.ViewModel.SignedUser. =;

            service.CreateOrUpdate(Bridge.ViewModel.SignedUser);
            oldpsw = "";
            (o as PasswordBox).Password = "";
        }
    }
}
