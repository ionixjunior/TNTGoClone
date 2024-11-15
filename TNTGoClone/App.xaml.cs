using System;
using TNTGoClone.Views;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace TNTGoClone
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainView();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
