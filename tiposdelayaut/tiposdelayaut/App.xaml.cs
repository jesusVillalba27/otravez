namespace tiposdelayaut
{
    public partial class App : Application
    {
        public static FlyoutPage flyoutPage {  get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new Inicial();
        }
    }
}
