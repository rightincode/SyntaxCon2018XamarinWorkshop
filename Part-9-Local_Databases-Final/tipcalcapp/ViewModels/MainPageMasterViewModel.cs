﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace tipcalcapp.ViewModels
{
    public class MainPageMasterViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MainPageMenuItem> MenuItems { get; set; }

        public MainPageMasterViewModel(bool LoggedIn)
        {
            MenuItems = new ObservableCollection<MainPageMenuItem>(new[]
            {
                    new MainPageMenuItem { Id = 0, Title = "Home", Image = "baseline_home_black_18dp.png", IsEnabled = true },
                    new MainPageMenuItem { Id = 1, Title = "Tip Calculator", Image = "baseline_payment_black_18dp.png", IsEnabled = true },
                    new MainPageMenuItem { Id = 2, Title = "Tip History", Image = "baseline_list_black_18dp.png", IsEnabled = true },
            });

            //if (LoggedIn)
            //{
            //    MenuItems.Add(new MainPageMenuItem { Id = 4, Title = "Logout", Image = "baseline_globe_black_18dp.png", IsEnabled = true });
            //}
            //else
            //{
            //    MenuItems.Add(new MainPageMenuItem { Id = 3, Title = "Login", Image = "baseline_globe_black_18dp.png", IsEnabled = true });
            //}
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
