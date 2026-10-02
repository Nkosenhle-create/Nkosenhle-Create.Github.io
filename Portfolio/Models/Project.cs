namespace Portfolio.Models
{
    public class Project
    {
        public string Slug { get; set; } = "";
        public string Title { get; set; } = "";
        public string Summary { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string> Tech { get; set; } = new();
        public List<string> Highlights { get; set; } = new();
        public string GitHubUrl { get; set; } = "";
        public string LiveUrl { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public int Year { get; set; }
        public bool Featured { get; set; }
    }
}
