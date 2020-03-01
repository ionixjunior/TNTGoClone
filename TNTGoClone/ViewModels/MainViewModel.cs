using System.Collections.Generic;
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
        private MovieViewModel _movieViewModel;
        private ShowViewModel _showViewModel;

        public IList<AppPage> Pages { get; private set; }

        public MainViewModel()
        {
            _api = ApiService.Instance;
            _liveViewModel = new LiveViewModel(_api);
            _movieViewModel = new MovieViewModel(_api);
            _showViewModel = new ShowViewModel(_api);

            Pages = GetPages();
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
                    Type = AppPageType.Movie,
                    ViewModel = _movieViewModel
                },
                new AppPage
                {
                    Name = "SHOWS",
                    Icon = "menu_show",
                    Type = AppPageType.Show,
                    ViewModel = _showViewModel
                },
                new AppPage
                {
                    Name = "EXTRAS",
                    Icon = "menu_extra",
                    Type = AppPageType.Extra
                }
            };
        }
    }
}
