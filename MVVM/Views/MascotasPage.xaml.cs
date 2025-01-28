using Repaso.MVVM.ViewModels;

namespace Repaso.MVVM.Views;

public partial class MascotasPage : ContentPage
{
	public MascotasPage()
	{
		InitializeComponent();
        BindingContext = new MascotasViewModel();
    }
}