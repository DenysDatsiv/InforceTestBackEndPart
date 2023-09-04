namespace InforceTest.Models
{
    public class Link
    {
        public int Id { get; set; }
        public string OriginalUrl { get; set; }
        public string ShortenerUrl { get; set; }
        public string CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set; } 
    }
}
