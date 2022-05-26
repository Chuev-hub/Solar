using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Solar.UI.Infrastructure
{
    public class SwitcherGuitar
    {
        public static INavigate ContentArea { get; set; }
        public static void Switch(UserControl page)
        {
            ContentArea.Navigate(page);
        }
    }
}
