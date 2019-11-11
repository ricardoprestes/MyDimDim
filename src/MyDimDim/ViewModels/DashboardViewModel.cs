using System;
using System.Collections.ObjectModel;
using MyDimDim.Enums;
using MyDimDim.Models;

namespace MyDimDim.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        decimal _balance;

        public decimal Balance
        {
            get => _balance;
            set => SetProperty(ref _balance, value);
        }

        decimal _revenues;
        public decimal Revenues
        {
            get => _revenues;
            set => SetProperty(ref _revenues, value);
        }

        decimal _expenses;
        public decimal Expenses
        {
            get => _expenses;
            set => SetProperty(ref _expenses, value);
        }

        public ObservableCollection<Movimentation> Movimentations { get; set; }

        public DashboardViewModel()
        {
            Balance = 5530;
            Revenues = 2500;
            Expenses = 2335;

            Movimentations = new ObservableCollection<Movimentation>
            {
                new Movimentation{Type= EMovimentationType.Revenue, Date = DateTime.Today, Value=3000, Name="Pagamento" },
                new Movimentation{Type= EMovimentationType.Expense, Date = DateTime.Today.AddDays(2), Value=1000, Name="Aluguel" },
                new Movimentation{Type= EMovimentationType.Expense, Date = DateTime.Today.AddDays(3), Value=120, Name="Conta de Água" }
            };
        }
    }
}
