using MVVM.ViewModel;

namespace MVVM.View;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(NewsDetailViewModel newsDetailViewModel)
	{
		InitializeComponent();
		BindingContext = newsDetailViewModel;
	}
}