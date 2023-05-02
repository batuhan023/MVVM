using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Services;
using MVVM.Model;
using System.Net.Http.Json;

namespace MVVM.Services
{
    public class NewsService
    {
        private HttpClient httpClient;
        private List<News> news = new();
        public NewsService()
        {
            httpClient = new HttpClient();
        }
        public async Task<List<News>> GetNewsAsync()
        {
            var url = "https://mocki.io/v1/018c8f0e-9869-4ae8-bc91-730326af5d35";
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                news = await response.Content.ReadFromJsonAsync<List<News>>();
            }
            return news;
        }
    }
}
