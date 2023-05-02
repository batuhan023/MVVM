using MVVM.ViewModel;
namespace MVVM.View;

public partial class NewsPage : ContentPage
{
	public NewsPage(NewsViewModel newsViewModel)
	{
		InitializeComponent();
		BindingContext = newsViewModel;

	}
}