using TNTGoClone.ViewModels;
using Xamarin.Forms;

namespace TNTGoClone.Views
{
	public partial class MainView : ContentPage
	{
        public static MainView Instance { get; private set; }

		public MainView()
		{
			InitializeComponent();
			BindingContext = new MainViewModel();
            Instance = this;
		}
    }
}
