
namespace MauiMvvmTest;

public partial class MainPage : ContentPage
{
    public MainViewModel VM { get; } = new MainViewModel();

	public string PreviewImageSource => "image.png";

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnDeleteClicked(object sender, EventArgs e)
    {

    }
}
