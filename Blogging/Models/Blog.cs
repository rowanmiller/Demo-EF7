namespace Blogging.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int AvgRating { get; set; }
        public string Notes { get; set; }
    }
}