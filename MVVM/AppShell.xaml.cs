using MVVM.View;

namespace MVVM;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(NewsDetailPage),typeof(NewsDetailPage));
	}
}
