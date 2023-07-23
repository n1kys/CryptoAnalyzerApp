using CryptoAnalyzerApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAnalyzerApp
{
    public class ViewModelLocator
    {
        public MainViewModel MainViewModel => Ioc.Resolve<MainViewModel>();
        public MainPageViewModel MainPageViewModel => Ioc.Resolve<MainPageViewModel>();
        public FullListPageViewModel FullListPageViewModel => Ioc.Resolve<FullListPageViewModel>();
    }
}
