using Cashflow.Maui.View.Category;
using Cashflow.Maui.View.Expense;
using Cashflow.Maui.View.ScanReceipt;
using Cashflow.Maui.View.Statistic;
using Cashflow.Maui.View.User;
using Core.ViewModels;
using Core.ViewModels.User;
using Microsoft.Extensions.Logging;

namespace Cashflow.Maui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<CategoryPage>();
        builder.Services.AddTransient<AddExpensePage>();
        builder.Services.AddTransient<DetailsExpensePage>();
        builder.Services.AddTransient<ExpensePage>();
        builder.Services.AddTransient<ScanReceiptPage>();
        builder.Services.AddTransient<StatisticPage>();
        builder.Services.AddTransient<RegistrationPage>();
        builder.Services.AddTransient<SignInPage>();
        builder.Services.AddTransient<UserPage>();
        builder.Services.AddTransient<WelcomePage>();

        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<CategoryViewModel>();
        builder.Services.AddTransient<AddExpenseViewModel>();
        builder.Services.AddTransient<DetailsViewModel>();
        builder.Services.AddTransient<ExpenseViewModel>();
        builder.Services.AddTransient<RegistrationViewModel>();
        builder.Services.AddTransient<SignInViewModel>();
        builder.Services.AddTransient<UserViewModel>();
        builder.Services.AddTransient<WelcomeViewModel>();
        builder.Services.AddTransient<ScanReceiptViewModel>();
        builder.Services.AddTransient<StatisticViewModel>();








        return builder.Build();
	}
}

