using System;
using System.Threading.Tasks;
using MvvmHelpers;
using TNTGoClone.Interfaces;
using TNTGoClone.Models;

namespace TNTGoClone.ViewModels
{
    public class MovieViewModel
    {
        private readonly IApi _api;
        private bool _alreadyInitialized = false;

        public ObservableRangeCollection<Movie> Movies { get; private set; }

        public MovieViewModel(IApi api)
        {
            _api = api;
            Movies = new ObservableRangeCollection<Movie>();
        }

        public async Task InitializeAsync()
        {
            if (_alreadyInitialized)
                return;

            await GetMovies();
            _alreadyInitialized = true;
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
