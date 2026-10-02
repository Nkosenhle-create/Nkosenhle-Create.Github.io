namespace Portfolio.Models
{
    public class Profile
    {
        public string Name { get; set; } = "";
        public string Title { get; set; } = "";
        public string Tagline { get; set; } = "";
        public string About { get; set; } = "";
        public string Location { get; set; } = "";
        public string Email { get; set; } = "";
        public string GitHub { get; set; } = "";
        public string LinkedIn { get; set; } = "";
        public string AvatarUrl { get; set; } = "";
        public string CvUrl { get; set; } = "";
        public List<SkillGroup> Skills { get; set; } = new();

        public string Initials => string.Concat(
            Name.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Take(2)
                .Select(w => char.ToUpperInvariant(w[0])));
    }

    public class SkillGroup
    {
        public string Category { get; set; } = "";
        public List<string> Items { get; set; } = new();
    }
}
