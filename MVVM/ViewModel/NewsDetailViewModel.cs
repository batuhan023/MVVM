using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Model;

namespace MVVM.ViewModel
{
    [QueryProperty(nameof(News),"News")]
    public partial class NewsDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        News news;
    }
}
