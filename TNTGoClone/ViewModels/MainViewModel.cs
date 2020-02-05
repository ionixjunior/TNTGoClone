using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmHelpers;
using TNTGoClone.Interfaces;
using TNTGoClone.Models;
using TNTGoClone.Services;

namespace TNTGoClone.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IApi _api;

        public IList<AppPage> Pages { get; private set; }
        public ObservableRangeCollection<Live> Lives { get; private set; }

        public MainViewModel()
        {
            _api = ApiService.Instance;

            Pages = GetPages();
            Lives = new ObservableRangeCollection<Live>();
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
            await LoadLives();
        }

        private async Task LoadLives()
        {
            try
            {
                var lives = await _api.GetLives();
                Lives.AddRange(lives);
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
        }
    }
}
