using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAnalyzerApp
{
    public static class Ioc
    {
        private static readonly ServiceProvider _provider;

        static Ioc()
        {
            var services = new ServiceCollection();




            _provider = services.BuildServiceProvider();
        }


        public static T Resolve<T>() => _provider.GetRequiredService<T>();

    }
}
