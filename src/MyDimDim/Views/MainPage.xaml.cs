using System.ComponentModel;
using MyDimDim.Views;
using Xamarin.Forms;

namespace MyDimDim
{
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            Children.Add(new DashboardPage { Title = "Dashboard", IconImageSource = "chart_arc" });
            Children.Add(new TransactionsPage { Title = "Movimentações", IconImageSource = "finance" });
            Children.Add(new ProfilePage { Title = "Perfil", IconImageSource = "account_circle" });
        }
    }
}
