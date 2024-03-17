namespace SearchApp.Models
{
    public class AutoResponse
    {
        public string? Query { get; set; }
        public List<AutoOption>? Options { get; set; }
        public string? Locale { get; set; }
    }

    public class AutoOption
    {
        public string? prefix { get; set; }
        public string? suffix { get; set; }
    }
}
