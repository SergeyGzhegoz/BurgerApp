namespace BurgerApp;

public partial class OrderPage : ContentPage
{
	public OrderPage()
	{
		InitializeComponent();
        BindingContext = ViewModelLocator.BurgerViewModel;
    }
}