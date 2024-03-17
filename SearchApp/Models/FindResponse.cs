using SearchApp.Components.Pages;

namespace SearchApp.Models
{
    public class FindItemResponse
    {
        public string? Query { get; set; }
        public List<FindItem>? Results { get; set; }
        public string? Locale { get; set; }
    }

    public class FindItem
    {
        public string? Text { get; set; }
        public string? ItemId { get; set; }
    }
}
