using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Windows.UI.Xaml.Controls;

using System.Collections.ObjectModel;

namespace MyTestApp.Views
{
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {


        public MainPage()
        {
            InitializeComponent();
            elencostati.Add("Italia");
            elencostati.Add("Francia");
            elencostati.Add("Svizzera");

            State.ItemsSource = elencostati;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        ObservableCollection<string> elencostati = new ObservableCollection<string>();

    }

}
