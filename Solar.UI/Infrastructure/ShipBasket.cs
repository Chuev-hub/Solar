using Solar.BLL.DTO;
using Solar.BLL.Services;
using Solar.DAL.Context;
using Solar.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Solar.UI.Infrastructure
{
    static class ShipBasket
    {
        public static ObservableCollection<GuitarDTO> Products { get; set; } = new ObservableCollection<GuitarDTO>();
        public static UserBasketService service = new UserBasketService(new UsersBasketRepository(new SiteContext()));
        private static string count;

        public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;
        static ShipBasket()
        {
            Refresh();
        }
        public static string Count
        {
            get { return count; }
            set
            {
                count = value;
                StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(Count)));
            }
        }
        public static void Save()
        {
            if (Bridge.ViewModel.SignedUser != null)
            {


                foreach (var i in service.GetAll())
                {
                    if (i.UserId == Bridge.ViewModel.SignedUser.UserId)
                        service.Delete(i);
                }
                foreach (var i in Products)
                {
                    UsersBasketDTO f = new UsersBasketDTO() { UserId = Bridge.ViewModel.SignedUser.UserId, Guitar = i };
                    service.CreateOrUpdate(f);
                }

                Refresh();
            }
        }
        public static void Upload(int id)
        {
            Products = null;
            Products = new ObservableCollection<GuitarDTO>(service.GetAll().Where(x => x.UserId == id).Select(y => y.Guitar)); ;

            if (Products == null)
                Products = new ObservableCollection<GuitarDTO>();
            Refresh();
        }
        public static void Refresh()
        {
            Count = Products.Count.ToString();
        }
    }
}
