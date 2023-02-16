namespace BurgerApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		BindingContext = ViewModelLocator.BurgerViewModel;
	}

}

