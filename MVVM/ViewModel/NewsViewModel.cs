using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Model;
using MVVM.Services;
using MVVM.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    public partial class NewsViewModel : ObservableObject
    {
        private NewsService newsService;
        public ObservableCollection<News> NewsCollection { get; set; } = new ObservableCollection<News>();
        public NewsViewModel(NewsService newsService)
        {
            this.newsService = newsService;
            GetNewsList();
        }

        private async void GetNewsList()
        {
            var news = await newsService.GetNewsAsync();
            foreach (var item in news)
            {
                NewsCollection.Add(item);
            }
        }

        //[ObservableProperty]
        //News selectedNews;


        //[RelayCommand]
        //void GoToDetails()
        //{
        //    if (SelectedNews == null) return;
        //    Shell.Current.GoToAsync($"{nameof(NewsDetailPage)}",
        //        new Dictionary<string, object>
        //        {
        //            {"News", SelectedNews}
        //        });
        //    SelectedNews = null;
        //}
        [RelayCommand]
        void GoToDetails(News news)
        {
            if (news == null) return;
            Shell.Current.GoToAsync($"{nameof(NewsDetailPage)}",
                new Dictionary<string, object>
                {
                    {"News", news}
                });
            news = null;
        }
    }
}

