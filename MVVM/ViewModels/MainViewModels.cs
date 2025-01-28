using Repaso.MVVM.Views;
using System.Windows.Input;

namespace Repaso.MVVM.ViewModels
{
    internal class MainViewModels
    {
        public ICommand NavigateToIVACommand { get; }
        public ICommand NavigateToMascotasCommand { get; }

        public MainViewModels(INavigation navigation)
        {
            NavigateToIVACommand = new Command(async () => await NavigateToIVA(navigation));
            NavigateToMascotasCommand = new Command(async () => await NavigateToMascotas(navigation));
        }

        private async Task NavigateToIVA(INavigation navigation)
        {
            await navigation.PushAsync(new IVAPage());
        }

        private async Task NavigateToMascotas(INavigation navigation)
        {
            await navigation.PushAsync(new MascotasPage());
        }
    }
}
