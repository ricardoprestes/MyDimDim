using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microcharts;
using MyDimDim.Enums;
using MyDimDim.Models;
using SkiaSharp;

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

        Chart _chart;
        public Chart Chart {
            get => _chart;
            private set => SetProperty(ref _chart, value);
        }

        public ObservableCollection<Movimentation> Movimentations { get; set; }
        public ObservableCollection<CreditCard> CreditCards { get; set; }

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

            CreditCards = new ObservableCollection<CreditCard>
            {
                new CreditCard{
                    Name = "NuBank",
                    Number = "**** **** *** 0000",
                    BillValue = 325.67m,
                    Expiration=DateTime.Today.AddDays(5),
                    CardColor = "#993399",
                    TextColor = "#FFF"
                },
                new CreditCard{
                    Name = "Bando do Brasil",
                    Number = "**** **** *** 1111",
                    BillValue = 123,
                    Expiration=DateTime.Today.AddDays(7),
                    CardColor = "#d9d630",
                    TextColor = "#000"
                }
            };
            Chart = GetChart();
        }

        Chart GetChart()
        {
            var entries = new List<Entry>
            {
                new Entry(1135)
                {
                    ValueLabel = "R$ 1135,00",
                    Label = "Moradia",
                    Color = SKColor.Parse("#f2be44")
                },
                new Entry(200)
                {
                    ValueLabel = "R$ 200,00",
                    Label = "Combustível",
                    Color = SKColor.Parse("#298a0b")
                },
                new Entry(100)
                {
                    ValueLabel = "R$ 100,00",
                    Label = "Academia",
                    Color = SKColor.Parse("#8c2f07")
                },
                new Entry(500)
                {
                    ValueLabel = "R$ 500,00",
                    Label = "Carro",
                    Color = SKColor.Parse("#51524e")
                },
                new Entry(400)
                {
                    ValueLabel = "R$ 400,00",
                    Label = "Outros",
                    Color = SKColor.Parse("#17736e")
                }
            };
            return new DonutChart { Entries = entries };
        }
    }
}
