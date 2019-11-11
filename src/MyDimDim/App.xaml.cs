using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using MyDimDim.Views;

namespace MyDimDim
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer)
        {
            
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            XF.Material.Forms.Material.Init(this);

            var startPage = nameof(NavigationPage) + "/" + nameof(MainPage);
            await NavigationService.NavigateAsync(startPage);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<TransactionsPage>();
            containerRegistry.RegisterForNavigation<ProfilePage>();
        }
    }
}
