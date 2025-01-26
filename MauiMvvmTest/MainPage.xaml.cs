
namespace MauiMvvmTest;

public partial class MainPage : ContentPage
{
    private bool _isPreviewVisible = false;
    public bool IsPreviewVisible
    {
        get => _isPreviewVisible;
        set
        {
            _isPreviewVisible = value;
            OnPropertyChanged(nameof(IsPreviewVisible));
        }
    }

    private bool _isDeleteButtonVisible = true;
    public bool IsDeleteButtonVisible
    {
        get => _isDeleteButtonVisible;
        set
        {
            _isDeleteButtonVisible = value;
            OnPropertyChanged(nameof(IsDeleteButtonVisible));
        }
    }

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnDeleteClicked(object sender, EventArgs e)
    {

    }
}
