using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TNTGoClone.ViewModels;
using Xamarin.Forms;

namespace TNTGoClone.Views
{
	public partial class MainView : ContentPage
	{
		private readonly MainViewModel _viewModel;
        private bool _alreadyLoaded = false;

		public MainView()
		{
			InitializeComponent();
			BindingContext = _viewModel = new MainViewModel();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
			await OnAppearingAsync();
        }

        private async Task OnAppearingAsync()
        {
            if (_alreadyLoaded)
                return;

            _alreadyLoaded = true;
            await _viewModel.InitializeAsync();
        }
    }
}
