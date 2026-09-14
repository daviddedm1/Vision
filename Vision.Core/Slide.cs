namespace Vision.Core
{
    public class Slide
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string BackgroundColor { get; set; } = "#000000"
        public int DurationSeconds { get; set; } = 0;

        public Slide() { }

        public Slide(int id, string title, string content, string backgroundColor = "#000000")
        {
            Id = id;
            Title = title;
            Content = content;
            BackgroundColor = backgroundColor;
        }
    }
}
