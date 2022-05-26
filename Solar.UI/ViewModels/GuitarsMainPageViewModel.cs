using Solar.BLL.DTO;
using Solar.UI.Infrastructure;
using Solar.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Solar.UI.ViewModels
{
    public class GuitarsMainPageViewModel:BaseNotifyPropertyChanged, INavigate
    {


        public GuitarsPageView GuitarsPage;
        public GuitarDTO guitarDTO { get; set; }
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
        public GuitarsMainPageViewModel()
        {
            SwitcherGuitar.ContentArea = this;
            GuitarsPageView n = new GuitarsPageView();
            GuitarsPage = n;
            (n.DataContext as GuitarsPageViewModel).guitarsMainPageViewModel = this;
          
            SwitcherGuitar.Switch(n);
        }

        public void ToGuitar()
        {
            SwitcherGuitar.ContentArea = this;
            GuitarPageView n = new GuitarPageView();
            GuitarPageViewModel nd = new GuitarPageViewModel();
            nd.GuitarsMainPageViewModel = this;
            nd.CurrentGuitar = guitarDTO;
            n.DataContext = nd;
            nd.fillPhoto();
            SwitcherGuitar.Switch(n);
        }
        public void Navigate(UserControl page)
        {
            ContentControl = page;
        }
    }
}
