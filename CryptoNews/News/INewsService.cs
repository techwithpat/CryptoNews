namespace CryptoNews.News
{
    public interface INewsService
    {
        Task<List<NewsItem>> GetNews();
    }
}
