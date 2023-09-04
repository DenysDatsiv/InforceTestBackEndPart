using InforceTest.Models;

namespace InforceTest.Repository
{
    public class LinkRepository
    {
        public static List<Link> Link = new()
        {
            new(){Id = 1,
                OriginalUrl = "https://www.example.com/page1",
                ShortenerUrl = "https://short.link/abc123",
                CreatedBy = "John Doe",
                CreatedDate = DateTime.Now.AddDays(-7)},
            new(){ Id = 2,
                OriginalUrl = "https://www.example.com/page2",
                ShortenerUrl = "https://short.link/def456",
                CreatedBy = "Jane Smith",
                CreatedDate = DateTime.Now.AddDays(-3)},
            new(){  Id = 3,
                OriginalUrl = "https://www.example.com/page3",
                ShortenerUrl = "https://short.link/ghi789",
                CreatedBy = "Alice Johnson",
                CreatedDate = DateTime.Now.AddDays(-1)},
        };
    }
} 
