using System.Collections.Generic;

namespace Vision.Core
{
    public class SlideGroup
    {
        public string Name { get; set; }
        public List<Slide> Slides { get; set; } = new List<Slide>();

        public SlideGroup() { }

        public SlideGroup(string name)
        {
            Name = name;
        }

        public void AddSlide(Slide slide)
        {
            Slides.Add(slide);
        }

        public override string ToString() => $"{Name} ({Slides.Count} slides)";
    }
}
