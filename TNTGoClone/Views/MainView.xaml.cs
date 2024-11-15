using TNTGoClone.Models;
using TNTGoClone.ViewModels;
using System.Linq;
using System;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace TNTGoClone.Views
{
	public partial class MainView : ContentPage
	{
		private MainViewModel _viewModel;

		public MainView()
		{
			InitializeComponent();
			BindingContext = _viewModel = new MainViewModel();
			SelectFirstItem();
		}

        private void SelectFirstItem()
        {
            if (Footer.Children.FirstOrDefault() is VerticalStackLayout stackLayout)
				ChangeState(stackLayout, "Selected");
		}

        void CarouselView_CurrentItemChanged(System.Object sender, Microsoft.Maui.Controls.CurrentItemChangedEventArgs e)
        {
			if (e.CurrentItem is AppPage currentItem)
			{
				var currentPageIndex = _viewModel.Pages.IndexOf(currentItem);

				if (Footer.Children[currentPageIndex] is VerticalStackLayout stackLayout)
					ChangeState(stackLayout, "Selected");
			}

            if (e.PreviousItem is AppPage previousItem)
            {
				var previousPageIndex = _viewModel.Pages.IndexOf(previousItem);

				if (Footer.Children[previousPageIndex] is VerticalStackLayout stackLayout)
					ChangeState(stackLayout, "UnSelected");
			}
		}

        private void ChangeState(VerticalStackLayout stackLayout, string stateName)
        {
			if (stackLayout.Children.FirstOrDefault() is Image icon)
				VisualStateManager.GoToState(icon, stateName);

			if (stackLayout.Children.LastOrDefault() is Label name)
				VisualStateManager.GoToState(name, stateName);
		}

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
			if (sender is VerticalStackLayout stackLayout)
            {
				var index = Footer.Children.IndexOf(stackLayout);
			    CarouselView.ScrollTo(index);
            }
        }
    }
}
