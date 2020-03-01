using TNTGoClone.ViewModels;
using Xamarin.Forms;

namespace TNTGoClone.Views
{
	public partial class MainView : ContentPage
	{
		public MainView()
		{
			InitializeComponent();
			BindingContext = new MainViewModel();
		}
    }
}
