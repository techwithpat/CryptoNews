namespace CryptoNews.News
{    
    public class NewsDto
    {
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public string screen_ID { get; set; }
        public Screen_Data screen_data { get; set; }
        public string screen_layout { get; set; }
    }

    public class Screen_Data
    {
        public string ob { get; set; }
        public int next_page { get; set; }
        public News[] news { get; set; }
    }

    public class News
    {
        public int news_ID { get; set; }
        public string hash { get; set; }
        public string providerId { get; set; }
        public string itemCategoryTags { get; set; }
        public string news_provider_name { get; set; }
        public string last_updated { get; set; }
        public int last_updated_uts { get; set; }
        public string type { get; set; }
        public string HEADLINE { get; set; }
        public string BODY { get; set; }
        public string news_link { get; set; }
        public string third_party_url { get; set; }
        public string related_image { get; set; }
        public string related_image_big { get; set; }
        public string vid_filename { get; set; }
        public string comments_cnt { get; set; }
        public string is_partial { get; set; }
        public string itemType { get; set; }
    }

}
