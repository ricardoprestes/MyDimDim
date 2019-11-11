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

        decimal _revenue;
        public decimal Revenue
        {
            get => _revenue;
            set => SetProperty(ref _revenue, value);
        }

        decimal _expenses;
        public decimal Expenses {
            get => _expenses;
            set => SetProperty(ref _expenses, value);
        }

        public DashboardViewModel()
        {
            Balance = 5530;
            Revenue = 2500;
            Expenses = 2335;
        }
    }
}
