using System.Collections.ObjectModel;

namespace PtMobile;

public partial class MainPage : ContentPage
{
    public ObservableCollection<ArtworkModel> Artworks { get; set; }

    public MainPage()
    {
        InitializeComponent();

        Artworks = new ObservableCollection<ArtworkModel>
        {
            new ArtworkModel { Image="drawfive.jpeg",  Title="Peach Tree in Blossom", Price="$950,000" },
            new ArtworkModel { Image="drawfour.jpeg",  Title="A Wheatfield with Cypresses", Price="$1,920,000" },
            new ArtworkModel { Image="drawone.jpeg",   Title="Starry Night Over the Rhône", Price="$800,000" },
            new ArtworkModel { Image="drawseven.jpeg", Title="The Yellow House", Price="$1,300,000" },
            new ArtworkModel { Image="drawsix.jpeg",   Title="Sunflower", Price="$1,300,000" },
            new ArtworkModel { Image="drawthree.jpeg", Title="Sky with forest", Price="$1,300,000" }
        };

        BindingContext = this;
    }
}

public class ArtworkModel
{
    public string Image { get; set; }
    public string Title { get; set; }
    public string Price { get; set; }
}
