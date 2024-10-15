namespace tiposdelayaut;

public partial class Inicial : FlyoutPage
{
    public Inicial()
    {
        InitializeComponent();  // Esta línea es necesaria para cargar el archivo XAML asociado.
        Flyout = new Maestro();
        Detail = new NavigationPage(new Detalle());

        App.flyoutPage = this;
    }
}
