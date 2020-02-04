using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmHelpers;
using TNTGoClone.Models;

namespace TNTGoClone.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public IList<AppPage> Pages { get; private set; }

        public MainViewModel()
        {
            Pages = GetPages();
        }

        private IList<AppPage> GetPages()
        {
            return new List<AppPage>
            {
                new AppPage { Name = "LIVE" },
                new AppPage { Name = "MOVIES" },
                new AppPage { Name = "SHOWS" },
                new AppPage { Name = "EXTRAS" }
            };
        }

        public async Task InitializeAsync()
        {
        }
    }
}
