using GalaSoft.MvvmLight.Command;
using Solar.BLL.DTO;
using Solar.BLL.Services;
using Solar.DAL.Context;
using Solar.DAL.Repositories;
using Solar.UI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RelayCommand = Solar.UI.Infrastructure.RelayCommand;

namespace Solar.UI.ViewModels
{
    class ShipBasketPageViewModel:BaseNotifyPropertyChanged
    {

        int sum;
        public int Sum { get => sum; set { sum = value; NotifyOfPopertyChanged(); } }
        string exc;
        public string Exc { get => exc; set {exc = value; NotifyOfPopertyChanged();}}
        public  ObservableCollection<GuitarDTO> Products { get; set; }
        OrderService os = new OrderService(new OrderRepository(new SiteContext()));
        ProductOrderService pos = new ProductOrderService(new ProductOrderRepository(new SiteContext()));
        public ShipBasketPageViewModel()
        {
            Exc = "";
            Products = ShipBasket.Products;

            Sum = ShipBasket.Products.Sum(x => x.Price);
            BuyCommand = new RelayCommand(x => {

                if(Products.Count==0)
                {
                    Exc = "Empty";
                }
                if(Bridge.ViewModel.SignedUser ==null)
                {
                    Exc = "Register";
                }
                if (Products.Count > 0 && Bridge.ViewModel.SignedUser != null)
                {
                    OrderDTO d = new OrderDTO()
                    {
                        IsEnded = false,
                        EndDate = "",
                        Price = Convert.ToDouble(ShipBasket.Products.Sum(i => i.Price)),
                        StartDate = ((DateTime.Now.Day).ToString() + "-" + (DateTime.Now.Month).ToString() + "-" + (DateTime.Now.Year).ToString()).ToString(),
                        UserId = Bridge.ViewModel.SignedUser.UserId
                        ,
                        UserName = Bridge.ViewModel.SignedUser.Name,
                        UserSurName = Bridge.ViewModel.SignedUser.SurName
                    };
                    int last = Bridge.ViewModel.SignedUser.Orders.Count;
                    os.CreateOrUpdate(d);
                    OrderDTO ls = os.GetAll().ToList()[last];
                    Bridge.ViewModel.SignedUser.Orders.Add(ls);

                    foreach (var i in Products)
                        pos.CreateOrUpdate(new ProductOrderDTO() { GuitarId = i.GuitarId, OrderId = ls.OrderId });
                    ShipBasket.Products.Clear();
                    ShipBasket.Count = "0";
                    Sum = 0;
                    ShipBasket.Save();
                }

            });
        }
        public ICommand RemoveCommand { get => new RelayCommand<int>(Remove); }
        public ICommand BuyCommand { get; set; }
        private void Remove(int param)
        {
            Products.Remove(Products.FirstOrDefault(x => x.GuitarId == param));
            Bridge.ViewModel.Num = (Convert.ToInt32(Bridge.ViewModel.Num) - 1).ToString();
            Sum = Products.Sum(x => x.Price);
            ShipBasket.Save();
            ShipBasket.Refresh();
        }
    }
}
