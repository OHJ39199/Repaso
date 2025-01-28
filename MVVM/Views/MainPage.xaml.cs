
using Repaso.MVVM.ViewModels;

namespace Repaso.MVVM.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
    {
		InitializeComponent();
        BindingContext = new MainViewModels(Navigation);
    }

	
}