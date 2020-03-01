using System;
using System.Threading.Tasks;
using MvvmHelpers;
using TNTGoClone.Interfaces;
using TNTGoClone.Models;

namespace TNTGoClone.ViewModels
{
    public class ExtraViewModel
    {
        private readonly IApi _api;
        private bool _alreadyInitialized = false;

        public ObservableRangeCollection<Extra> Extras { get; private set; }

        public ExtraViewModel(IApi api)
        {
            _api = api;
            Extras = new ObservableRangeCollection<Extra>();
        }

        public async Task InitializeAsync()
        {
            if (_alreadyInitialized)
                return;

            await GetExtras();
            _alreadyInitialized = true;
        }

        private async Task GetExtras()
        {
            try
            {
                var extras = await _api.GetExtras();
                Extras.AddRange(extras);
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
        }
    }
}
