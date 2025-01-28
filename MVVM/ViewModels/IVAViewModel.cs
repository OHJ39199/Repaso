
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Repaso.MVVM.ViewModels
{
    public class IVAViewModel : INotifyPropertyChanged
    {
        private string _amount;
        private int _selectedIVARate;
        private bool _isResultVisible;
        private decimal _baseAmount;
        private decimal _ivaAmount;
        private decimal _totalAmount;

        public string Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }

        public ObservableCollection<int> IVARates { get; } = new ObservableCollection<int> { 4, 10, 21 };

        public int SelectedIVARate
        {
            get => _selectedIVARate;
            set
            {
                _selectedIVARate = value;
                OnPropertyChanged(nameof(SelectedIVARate));
            }
        }

        public bool IsResultVisible
        {
            get => _isResultVisible;
            set
            {
                _isResultVisible = value;
                OnPropertyChanged(nameof(IsResultVisible));
            }
        }

        public decimal BaseAmount
        {
            get => _baseAmount;
            set
            {
                _baseAmount = value;
                OnPropertyChanged(nameof(BaseAmount));
            }
        }

        public decimal IVAAmount
        {
            get => _ivaAmount;
            set
            {
                _ivaAmount = value;
                OnPropertyChanged(nameof(IVAAmount));
            }
        }

        public decimal TotalAmount
        {
            get => _totalAmount;
            set
            {
                _totalAmount = value;
                OnPropertyChanged(nameof(TotalAmount));
            }
        }

        public ICommand CalculateCommand { get; }

        public IVAViewModel()
        {
            CalculateCommand = new Command(Calculate);
            SelectedIVARate = IVARates[2]; // Default to 21%
        }

        private void Calculate()
        {
            if (decimal.TryParse(Amount, out decimal amount) && SelectedIVARate > 0)
            {
                BaseAmount = amount;
                IVAAmount = amount * (SelectedIVARate / 100m);
                TotalAmount = BaseAmount + IVAAmount;
                IsResultVisible = true;
            }
            else
            {
                IsResultVisible = false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
