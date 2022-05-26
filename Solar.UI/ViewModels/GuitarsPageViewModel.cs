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
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Solar.UI.ViewModels
{
    public class GuitarsPageViewModel : BaseNotifyPropertyChanged
    {
        public GuitarsMainPageViewModel guitarsMainPageViewModel;




        public ObservableCollection<GuitarDTO> guitars;
        public ObservableCollection<GuitarDTO> Guitars
        {
            get => guitars;
            set
            {
                guitars = value;
                NotifyOfPopertyChanged();
            }
        }
        public GuitarDTO currentGuitar;
        public GuitarDTO CurrentGuitar
        {
            get => currentGuitar;
            set
            {
                currentGuitar = value;
                NotifyOfPopertyChanged();
            }
        }
        GuitarService guitarService = new GuitarService(new GuitarRepository(new SiteContext()));
        string state = "All";
        public GuitarsPageViewModel()
        {

            CurrentGuitar = new GuitarDTO();
            AllCommand = new RelayCommand(x =>
            {
                if (GuitarDTOs.Count >= 10)
                    Guitars = new ObservableCollection<GuitarDTO>(GuitarDTOs.Take(10));
                else
                    Guitars = new ObservableCollection<GuitarDTO>(GuitarDTOs);
                state = "All";

            });
            ABCommand = new RelayCommand(x =>
            {
                ObservableCollection<GuitarDTO> b = new ObservableCollection<GuitarDTO>(GuitarDTOs.Where(u => u.GuitarCategoryName == "AB"));
                if (b.Count >= 10)
                    Guitars = new ObservableCollection<GuitarDTO>(b.Take(10));
                else
                    Guitars = new ObservableCollection<GuitarDTO>(b);
                state = "AB";
            });
            ECommand = new RelayCommand(x =>
            {
                ObservableCollection<GuitarDTO> b = new ObservableCollection<GuitarDTO>(GuitarDTOs.Where(u => u.GuitarCategoryName == "E"));
                if (b.Count >= 10)
                    Guitars = new ObservableCollection<GuitarDTO>(b.Take(10));
                else
                    Guitars = new ObservableCollection<GuitarDTO>(b);
                state = "E";
            });
            VCommand = new RelayCommand(x =>
            {
                ObservableCollection<GuitarDTO> b = new ObservableCollection<GuitarDTO>(GuitarDTOs.Where(u => u.GuitarCategoryName == "V"));
                if (b.Count >= 10)
                    Guitars = new ObservableCollection<GuitarDTO>(b.Take(10));
                else
                    Guitars = new ObservableCollection<GuitarDTO>(b);
                state = "V";
            });
            GCommand = new RelayCommand(x =>
            {
                ObservableCollection<GuitarDTO> b = new ObservableCollection<GuitarDTO>(GuitarDTOs.Where(u => u.GuitarCategoryName == "G"));
                if (b.Count >= 10)
                    Guitars = new ObservableCollection<GuitarDTO>(b.Take(10));
                else
                    Guitars = new ObservableCollection<GuitarDTO>(b);
                state = "G";
            });
            MoreCommand = new RelayCommand((x) =>
            {
                int num = Guitars.Count;
                ObservableCollection<GuitarDTO> b;
                if (state == "All")
                    b = GuitarDTOs;
                else
                    b = new ObservableCollection<GuitarDTO>(GuitarDTOs.Where(u => u.GuitarCategoryName == state));
                if (b.Count > num)
                    if (b.Count - num >= 5)
                    {
                        foreach (var i in b.Skip(num).Take(5))
                            Guitars.Add(i);
                    }
                    else
                    {
                        foreach (var i in b.Skip(num))
                            Guitars.Add(i);
                    }

            });
            EvD += (x) =>
            {
                if (x.Count >= 10)
                    Guitars = new ObservableCollection<GuitarDTO>(x.Take(10));
                else
                    Guitars = new ObservableCollection<GuitarDTO>(x);
            };
            if (GuitarDTOs.Count >= 10)
                Guitars = new ObservableCollection<GuitarDTO>(GuitarDTOs.Take(10));
            else
                Guitars = new ObservableCollection<GuitarDTO>(GuitarDTOs);
        }
        public delegate void D(ObservableCollection<GuitarDTO> f);
        public static event D EvD;
        public static ObservableCollection<GuitarDTO> guitarDTOs;
        public static ObservableCollection<GuitarDTO> GuitarDTOs
        {
            get => guitarDTOs; set
            {
                guitarDTOs = value;
                EvD?.Invoke(guitarDTOs);
            }
        }
        public void DoubleClickMethod()
        {
            guitarsMainPageViewModel.guitarDTO = currentGuitar;
            guitarsMainPageViewModel.ToGuitar();
        }

        public ICommand AllCommand { set; get; }
        public ICommand ABCommand { set; get; }
        public ICommand ECommand { set; get; }
        public ICommand VCommand { set; get; }
        public ICommand GCommand { set; get; }
        public ICommand MoreCommand { set; get; }

    }
}
