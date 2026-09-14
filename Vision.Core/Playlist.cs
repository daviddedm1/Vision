using System;
using System.Collections.Generic;

namespace Vision.Core
{
    public class Playlist
    {
        public string Name { get; set; }
        public List<SlideGroup> Groups { get; set; } = new List<SlideGroup>();
        public DateTime CreatedDate { get; set; }

        public Playlist() 
        { 
            CreatedDate = DateTime.Now;
        }

        public Playlist(string name) : this()
        {
            Name = name;
        }

        public void AddGroup(SlideGroup group)
        {
            Groups.Add(group);
        }

        public int GetTotalSlides()
        {
            int total = 0;
            foreach (var group in Groups)
                total += group.Slides.Count;
            return total;
        }

        public override string ToString() => $"{Name} ({Groups.Count} groups, {GetTotalSlides()} slides)";
    }
}
