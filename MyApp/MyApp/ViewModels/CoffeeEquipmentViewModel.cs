using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyApp.ViewModels
{
    public class CoffeeEquipmentViewModel : BindableObject
    {
        public ICommand IncreaseCount { get; }
        public ICommand ResetCount { get; }

        int count = 0;
        string countDisplay = "Click Me !";

        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay) return;

                countDisplay = value;
                OnPropertyChanged(nameof(CountDisplay));
            }
        }

        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            ResetCount = new Command(OnReset);
        }

        void OnIncrease()
        {
            count++;
            CountDisplay = $"You clicked {count} time(s)";
        }

        void OnReset()
        {
            count = 0;
            CountDisplay = $"You clicked {count} time(s)";
        }
    }
}
