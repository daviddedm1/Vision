using System;
using System.Collections.Generic;

namespace Vision.Core
{
    public class VisionCore
    {
        public List<Playlist> Playlists { get; set; } = new List<Playlist>();
        public Slide CurrentSlide { get; set; }
        public bool IsRunning { get; set; }

        public event EventHandler<Slide> SlideChanged;

        public VisionCore()
        {
            IsRunning = false;
        }

        public void Start()
        {
            IsRunning = true;
            System.Diagnostics.Debug.WriteLine("Vision Core started");
        }

        public void Stop()
        {
            IsRunning = false;
            System.Diagnostics.Debug.WriteLine("Vision Core stopped");
        }

        public void PlaySlide(Slide slide)
        {
            if (slide == null) return;
            CurrentSlide = slide;
            SlideChanged?.Invoke(this, slide);
        }

        public void AddPlaylist(Playlist playlist)
        {
            Playlists.Add(playlist);
        }
    }
}
