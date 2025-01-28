using Repaso.MVVM.ViewModels;

namespace Repaso.MVVM.Views;

public partial class IVAPage : ContentPage
{
	public IVAPage()
	{
		InitializeComponent();
        BindingContext = new IVAViewModel();
    }
}