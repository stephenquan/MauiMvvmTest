using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiMvvmTest;

public partial class MainViewModel : ObservableObject
{
	[ObservableProperty]
	bool isPreviewVisible = false;

	[ObservableProperty]
	bool isDeleteButtonVisible = true;
}
