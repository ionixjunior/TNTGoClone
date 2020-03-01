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
        private LiveViewModel _liveViewModel;

        public IList<AppPage> Pages { get; private set; }
        public ObservableRangeCollection<Movie> Movies { get; private set; }

        public MainViewModel()
        {
            _api = ApiService.Instance;
            _liveViewModel = new LiveViewModel(_api);

            Pages = GetPages();
            Movies = new ObservableRangeCollection<Movie>();
        }

        private IList<AppPage> GetPages()
        {
            return new List<AppPage>
            {
                new AppPage
                {
                    Name = "LIVE",
                    Icon = "menu_live",
                    Type = AppPageType.Live,
                    ViewModel = _liveViewModel
                },
                new AppPage
                {
                    Name = "MOVIES",
                    Icon = "menu_movie",
                    Type = AppPageType.Movie
                },
                new AppPage
                {
                    Name = "SHOWS",
                    Icon = "menu_show",
                    Type = AppPageType.Show
                },
                new AppPage
                {
                    Name = "EXTRAS",
                    Icon = "menu_extra",
                    Type = AppPageType.Extra
                }
            };
        }

        public async Task InitializeAsync()
        {
            await GetMovies();
        }

        private async Task GetMovies()
        {
            try
            {
                var movies = await _api.GetMovies();
                Movies.AddRange(movies);
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
        }
    }
}
