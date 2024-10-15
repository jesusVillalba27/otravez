using System.Collections.ObjectModel;

namespace tiposdelayaut;

public partial class CollectionViewPage : ContentPage
{
    public CollectionViewPage()
    {
        InitializeComponent();

        // Configura el BindingContext para que utilice el ViewModel
        BindingContext = new CollectionViewPageViewModel();
    }

    // Clase de item con propiedades Name, Image y Description
    public class Item
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }

    // ViewModel que contiene los items para el CollectionView
    public class CollectionViewPageViewModel
    {
        public ObservableCollection<Item> Items { get; set; }

        public CollectionViewPageViewModel()
        {
            // Inicializa la lista de items con ejemplos
            Items = new ObservableCollection<Item>
            {
                new Item { Name = "Item 1", Image = "dotnet_bot.png", Description = "Description for item 1" },
                new Item { Name = "Item 2", Image = "dotnet_bot.png", Description = "Description for item 2" },
                // Puedes agregar más items aquí
            };
        }
    }
}
