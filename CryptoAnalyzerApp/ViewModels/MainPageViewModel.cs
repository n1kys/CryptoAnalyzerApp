using CryptoAnalyzerApp.Pages;
using CryptoAnalyzerApp.Services;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoAnalyzerApp.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private readonly PageService _navigation;

        public MainPageViewModel(PageService navigation)
        {
            _navigation = navigation;
        }


        public ICommand GoToFullList => new DelegateCommand(() =>
        {
            _navigation.Navigate(new FullListPage());
        });

        public ICommand GoToConverter => new DelegateCommand(() =>
        {
            //_navigation.Navigate(new ConverterPage());
        });

        public ICommand GoToGraphic => new DelegateCommand(() =>
        {
            //_navigation.Navigate(new GraphicPage());
        });

    }
}
