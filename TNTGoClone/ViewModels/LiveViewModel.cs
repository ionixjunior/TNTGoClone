using System;
using System.Threading.Tasks;
using MvvmHelpers;
using TNTGoClone.Interfaces;
using TNTGoClone.Models;

namespace TNTGoClone.ViewModels
{
    public class LiveViewModel
    {
        private readonly IApi _api;
        private bool _alreadyInitialized = false;

        public ObservableRangeCollection<Live> Lives { get; private set; }

        public LiveViewModel(IApi api)
        {
            _api = api;
            Lives = new ObservableRangeCollection<Live>();
        }

        public async Task InitializeAsync()
        {
            if (_alreadyInitialized)
                return;

            await GetLives();
            _alreadyInitialized = true;
        }

        private async Task GetLives()
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
