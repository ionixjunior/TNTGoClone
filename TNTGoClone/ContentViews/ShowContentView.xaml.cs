using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TNTGoClone.Models;
using TNTGoClone.ViewModels;
using Xamarin.Forms;

namespace TNTGoClone.ContentViews
{
    public partial class ShowContentView : ContentView
    {
        public ShowContentView()
        {
            InitializeComponent();
        }

        protected override async void OnBindingContextChanged()
        {
            await OnBindingContextChangedAsync();
        }

        private async Task OnBindingContextChangedAsync()
        {
            base.OnBindingContextChanged();

            if (BindingContext is AppPage appPage)
                if (appPage.ViewModel is ShowViewModel viewModel)
                    await viewModel.InitializeAsync();
        }
    }
}
