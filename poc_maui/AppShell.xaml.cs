using poc_maui.Views;

namespace poc_maui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(LandingPage),
               typeof(LandingPage));

        Routing.RegisterRoute(nameof(AttachmentsPage),
               typeof(AttachmentsPage));
    }
}

