using System;
using System.ComponentModel;
using System.Windows.Input;
using ДЗ_24._Калькулятор.Utilits;

namespace ДЗ_24._Калькулятор.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private double _result;
        private double _number;

        public double Result {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public double Number
        {
            get { return _number; }
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }

        public ICommand CalculateSinus { get; }
        public ICommand CalculateCosinus { get; }
        public ICommand CalculateFactorial { get; }

        public CalculatorViewModel()
        {
            CalculateSinus = new RelayCommand(Sinus);
            CalculateCosinus = new RelayCommand(Cosinus);
            CalculateFactorial = new RelayCommand(Factorial);

            Number = 0;
        }

        private void Cosinus()
        {
            Result = 0;
            Result = Math.Cos(Number);
        }

        private void Sinus()
        {
            Result = 0;
            Result = Math.Sin(Number);
        }

        private void Factorial()
        {
            Result = 0;
            int toFactorialNumber = Convert.ToInt32(Number);
            Result = FactorialCalculator.CalculateFactorial(toFactorialNumber);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

