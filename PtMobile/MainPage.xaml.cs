using System.Collections.ObjectModel;

namespace PtMobile;

public partial class MainPage : ContentPage
{
    public ObservableCollection<ItemModel> Items { get; set; }

    public MainPage()
    {
        InitializeComponent();

        Items = new ObservableCollection<ItemModel>
        {
            new ItemModel { Title = "A" },
            new ItemModel { Title = "B" },
            new ItemModel { Title = "C" },
            new ItemModel { Title = "D" }
        };

        BindingContext = this;
    }
}

public class ItemModel
{
    public string Title { get; set; }
}
