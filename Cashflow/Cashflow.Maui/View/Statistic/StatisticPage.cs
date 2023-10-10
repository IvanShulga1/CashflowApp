namespace Cashflow.Maui.View.Statistic;

public class StatisticPage : ContentPage
{
	public StatisticPage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}
