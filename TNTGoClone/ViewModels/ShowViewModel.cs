using System;
using System.Threading.Tasks;
using MvvmHelpers;
using TNTGoClone.Interfaces;
using TNTGoClone.Models;

namespace TNTGoClone.ViewModels
{
    public class ShowViewModel
    {
        private readonly IApi _api;
        private bool _alreadyInitialized = false;

        public ObservableRangeCollection<Show> Shows { get; private set; }

        public ShowViewModel(IApi api)
        {
            _api = api;
            Shows = new ObservableRangeCollection<Show>();
        }

        public async Task InitializeAsync()
        {
            if (_alreadyInitialized)
                return;

            await GetShows();
            _alreadyInitialized = true;
        }

        private async Task GetShows()
        {
            try
            {
                var shows = await _api.GetShows();
                Shows.AddRange(shows);
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
        }
    }
}
