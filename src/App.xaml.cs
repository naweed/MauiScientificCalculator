namespace MauiScientificCalculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalculatorPage();
	}
}
