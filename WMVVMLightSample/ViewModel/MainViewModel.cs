using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Practices.ServiceLocation;
using System;

namespace WMVVMLightSample.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _inputText;
        public string InputText
        {
            get { return _inputText; }
            set { _inputText = value; RaisePropertyChanged(); RaisePropertyChanged(nameof(LabelText)); }
        }

        public string LabelText => _inputText + _inputText;

        public RelayCommand Command { get; private set; }

        public MainViewModel()
        {
            Command = new RelayCommand(() => {
                ((MainWindow)App.Current.MainWindow).MainFrame.Source = new Uri("/View/SecondView.xaml", UriKind.Relative);
            });
        }

    }
}