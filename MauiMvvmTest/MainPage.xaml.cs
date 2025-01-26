
namespace MauiMvvmTest;

public partial class MainPage : ContentPage
{
    public MainViewModel VM { get; } = new MainViewModel();

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnDeleteClicked(object sender, EventArgs e)
    {

    }
}
