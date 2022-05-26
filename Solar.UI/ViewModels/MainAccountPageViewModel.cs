using Solar.BLL.DTO;
using Solar.UI.Infrastructure;
using Solar.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Solar.UI.ViewModels
{
   
    public class MainAccountPageViewModel : BaseNotifyPropertyChanged, INavigate
    {
        public MainViewModel mv;
        public UserDTO userDTO;
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
        public MainAccountPageViewModel()
        {
            SwitcherAct.ContentArea = this;
            Load();
        }
        public void Navigate(UserControl page)
        {
            ContentControl = page;
        }
        void Load()
        {
            if (Bridge.ViewModel.SignedUser == null)
            {
                AccountRegPageView y = new AccountRegPageView();
                AccountRegPageViewModel viewModel = new AccountRegPageViewModel();
                viewModel.mainAccount = this;
                y.DataContext = viewModel;
                SwitcherAct.Switch(y);
            }
            else
            {              
                SwitcherAct.Switch( new AccountPageView());
            }
        }
    }
}
