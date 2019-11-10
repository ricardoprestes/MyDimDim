using System.ComponentModel;
using MyDimDim.Views;
using Xamarin.Forms;

namespace MyDimDim
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            Children.Add(new DashboardPage { Title = "Dashboard" });
            Children.Add(new TransactionsPage { Title = "Transações" });
            Children.Add(new ProfilePage { Title = "Perfil" });
        }
    }
}
