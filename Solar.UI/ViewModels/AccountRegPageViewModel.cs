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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Solar.UI.ViewModels
{
    public class AccountRegPageViewModel : BaseNotifyPropertyChanged
    {
        public MainAccountPageViewModel mainAccount;
        public UserDTO UserDTO;
        public string eMAILreg;
        public string EMAILreg
        {
            get => eMAILreg; set
            { eMAILreg = value; NotifyOfPopertyChanged(); }
        }
        public string texts;
        public string Texts
        {
            get => texts; set
            { texts = value; NotifyOfPopertyChanged(); }
        }
        public string textsScs;
        public string TextsScs
        {
            get => textsScs; set
            { textsScs = value; NotifyOfPopertyChanged(); }
        }
        public string textsLog;
        public string TextsLog
        {
            get => textsLog; set
            { textsLog = value; NotifyOfPopertyChanged(); }
        }
        public string EMAILlog { get; set; }
        public string pSWlog;
        public string PSWlog
        {
            get => pSWlog; set
            { pSWlog = value; NotifyOfPopertyChanged(); }
        }
        public MainViewModel mv;
        public UserService userService { get; set; } 
        public AccountRegPageViewModel()
        {

            userService = new UserService(new UserRepository(new SiteContext()));
        }

        public ICommand SigninCommand { get => new RelayCommand<object>(Signin); }
        private void Signin(object param)
        {
            var passwordBox = param as PasswordBox;
         
            var password = passwordBox.Password;
            IEnumerable<UserDTO> n = userService.GetAll();
            Texts = "";
            TextsScs = "";
            if (EMAILreg == "" || password == "")
            {
                Texts = "Empty fields";

            }
            else
            {
                if (n.FirstOrDefault(f => f.Email == EMAILreg) == null)
                {
                    userService.CreateOrUpdate(new UserDTO() { Email = EMAILreg, Password = password.GetHashCode().ToString() });
                    TextsScs = "Registered";
                }
                else
                {
                    Texts = "You Already Registered";
                }
            }
            passwordBox.Password = "";
            EMAILreg = "";
        }
        public ICommand LoginCommand { get => new RelayCommand<object>(Login); }
        private void Login(object param)
        {
            var passwordBox = param as PasswordBox;
            if (param == null)
                return;
            var password = passwordBox.Password;
            TextsLog = "";
            IEnumerable<UserDTO> n = userService.GetAll();
            foreach (var i in n)
                if (i.Email == EMAILlog && i.Password == password.GetHashCode().ToString())
                {
                    Bridge.ViewModel.SignedUser = i;
                    ProductOrderService ProductOrder = new ProductOrderService(new ProductOrderRepository(new SiteContext()));
                    OrderService orderService = new OrderService(new OrderRepository(new SiteContext()));
                    Bridge.ViewModel.SignedUser.Orders = new ObservableCollection<OrderDTO>( orderService.GetAll().Where(x=>x.UserId==Bridge.ViewModel.SignedUser.UserId));
                    Switcher.Switch(new MainAccountPageView());
                    break;
                }
                else
                    TextsLog = "Register";
            passwordBox.Password = "";
            EMAILlog = "";
        }
    }
}
