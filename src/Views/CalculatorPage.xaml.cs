namespace MauiScientificCalculator.Views;

public partial class CalculatorPage : ContentPage
{
	private CalculatorPageViewModel calcViewModel;

	public CalculatorPage()
	{
		InitializeComponent();

		//Initialize the view model
		calcViewModel = new CalculatorPageViewModel();
		this.BindingContext = calcViewModel;
	}
}