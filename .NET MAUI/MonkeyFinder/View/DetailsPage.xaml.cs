using MonkeyFinder.ViewModel;

namespace MonkeyFinder.View;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(MonkeyDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}