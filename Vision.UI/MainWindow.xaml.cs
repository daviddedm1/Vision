using System.Windows;
using System.Windows.Controls;
using Vision.Core;

namespace Vision.UI
{
    public partial class MainWindow : Window
    {
        private OutputWindow outputWindow;
        public static VisionCore Core;

        public MainWindow()
        {
            InitializeComponent();

            Core = new VisionCore();
            Core.Start();

            outputWindow = new OutputWindow();
            outputWindow.Show();

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            var group1 = new SlideGroup("Welcome");
            group1.AddSlide(new Slide(1, "Welcome to Vision", "Professional Presentation Software", "#1E1E1E"));
            group1.AddSlide(new Slide(2, "Next Slide", "Let's get started", "#2C3E50"));

            var group2 = new SlideGroup("Content");
            group2.AddSlide(new Slide(3, "Topic 1", "Your content here", "#34495E"));
            group2.AddSlide(new Slide(4, "Topic 2", "More content", "#445566"));

            var playlist = new Playlist("My Presentation");
            playlist.AddGroup(group1);
            playlist.AddGroup(group2);

            Core.AddPlaylist(playlist);

            foreach (var group in playlist.Groups)
            {
                GroupList.Items.Add(group);
            }
        }

        private void GroupList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GroupList.SelectedItem is SlideGroup group)
            {
                SlideList.Items.Clear();
                foreach (var slide in group.Slides)
                {
                    SlideList.Items.Add(slide);
                }
            }
        }

        private void SlideList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SlideList.SelectedItem is Slide slide)
            {
                PreviewTitle.Text = slide.Title;
                PreviewContent.Text = slide.Content;
            }
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            if (SlideList.SelectedItem is Slide slide)
            {
                Core.PlaySlide(slide);
                outputWindow.ShowSlide(slide);
                MessageBox.Show($"Sent: {slide.Title}", "Vision", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please select a slide first.", "Vision", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void NewPlaylist_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New Playlist feature coming soon.", "Vision");
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Settings panel coming soon.", "Vision");
        }
    }
}
