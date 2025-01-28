
using Repaso.MVVM.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Repaso.MVVM.ViewModels
{
    public class MascotasViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Mascota> _mascotas;

        public ObservableCollection<Mascota> Mascotas
        {
            get => _mascotas;
            set
            {
                _mascotas = value;
                OnPropertyChanged(nameof(Mascotas));
            }
        }

        public MascotasViewModel()
        {
            LoadMascotas();
        }

        private void LoadMascotas()
        {
            Mascotas = new ObservableCollection<Mascota>
            {
                new Mascota
                {
                    Name = "Rex",
                    Breed = "Pastor Alemán",
                    ImageUrl = "dog.png",
                    Type = "Dog"
                },
                new Mascota
                {
                    Name = "Whiskers",
                    Breed = "Siamés",
                    ImageUrl = "cat.png",
                    Type = "Cat"
                },
                new Mascota
                {
                    Name = "Pelusa",
                    Breed = "Persa",
                    ImageUrl = "cat2.png",
                    Type = "Cat"
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
