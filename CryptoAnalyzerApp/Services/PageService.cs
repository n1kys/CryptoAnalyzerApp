using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CryptoAnalyzerApp.Services
{
    public class PageService
    {
        private Stack<Page> _history;
        public bool CanGoBack => _history.Skip(1).Any();

        public PageService()
        {
            _history = new Stack<Page>();


        }

        public event Action<Page> OnPageChanged;

        public void Navigate(Page page)
        {
            OnPageChanged?.Invoke(page);
            _history.Push(page);
        }

        public async void GoToBack()
        {
            _history.Pop();
            var page = _history.Peek();
            OnPageChanged?.Invoke(page);
        }
    }
}
