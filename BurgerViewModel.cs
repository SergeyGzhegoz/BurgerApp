using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BurgerApp
{
    public class BurgerViewModel: INotifyPropertyChanged
    {
        string typeofmeet = "";
        int count;
        int price;
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Burger> Order { get; } = new();
        public BurgerViewModel()
        {
            AddCommand = new Command((object? args) =>
            {
                Order.Add(new Burger(TypeOfMeet, Count, Price));
                TypeOfMeet = args.ToString();
                Count = 0;
                Price = 0;
            });
        }

        public string TypeOfMeet { 
            get => typeofmeet;
            set
            {
                if (typeofmeet != value)
                {
                    typeofmeet= value;
                    OnPropertyChanged();
                }
            }
        }

        public int Count
        {
            get => count;
            set
            {
                if (count != value)
                {
                    count = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Price
        {
            get => price;
            set
            {
                if (price != value)
                {
                    price = value;
                    OnPropertyChanged();
                }
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
