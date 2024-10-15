namespace tiposdelayaut;

public partial class Maestro : ContentPage
{
    public Maestro()
    {
        InitializeComponent();
    }

    private void GotoStackLayoutpage(object sender, EventArgs e)
    {
        NavigationPage(new StackLayout());
    }

    private void GotoGridpage(object sender, EventArgs e)
    {
        NavigationPage(new Grid());
    }


    private void GotoFlexLayoutpage(object sender, EventArgs e)
    {
        NavigationPage(new FlexLayout());
    }

    private void GotoAbsoluteLayoutpage(object sender, EventArgs e)
    {
        NavigationPage(new AbsoluteLayout());
    }




    private void GotoContentViewpage(object sender, EventArgs e)
    {
         NavigationPage(new ContentView());
    }

    private void GotoScrollViewpage(object sender, EventArgs e)
    {
        NavigationPage(new ScrollView());
    }

    private void GotoCollectionViewpage(object sender, EventArgs e)
    {
        NavigationPage(new CollectionView());
    }

    

    private void NavigationPage(ContentPage page) 
    
    { 
        App.flyoutPage.Detail.Navigation.PushModalAsync(page);
        App.flyoutPage.IsPresented=false;
    
    
    }
    


      
        
}
