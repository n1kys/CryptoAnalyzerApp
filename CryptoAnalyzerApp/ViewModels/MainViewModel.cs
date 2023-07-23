using CryptoAnalyzerApp.Pages;
using CryptoAnalyzerApp.Services;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace CryptoAnalyzerApp.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly PageService _navigation;
        public Page CurrentPage { get; set; }

        public MainViewModel(PageService navigation)
        {
            _navigation = navigation;
            navigation.OnPageChanged += page => CurrentPage = page;
            navigation.Navigate(new MainPage());
        }

        public ICommand GoToBack => new DelegateCommand(() =>
        {
            _navigation.GoToBack();
        }, () => _navigation.CanGoBack);
    }
}
