using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Vision.Core;

namespace Vision.UI
{
    public partial class OutputWindow : Window
    {
        public OutputWindow()
        {
            InitializeComponent();
        }

        public void ShowSlide(Slide slide)
        {
            if (slide == null) return;

            // Fade out animation
            var fadeOut = new DoubleAnimation(1, 0, TimeSpan.FromMilliseconds(300));
            fadeOut.Completed += (s, e) =>
            {
                // Update content
                TitleText.Text = slide.Title;
                ContentText.Text = slide.Content;

                // Set background color
                try
                {
                    MainGrid.Background = new SolidColorBrush(
                        (Color)ColorConverter.ConvertFromString(slide.BackgroundColor)
                    );
                }
                catch
                {
                    MainGrid.Background = Brushes.Black;
                }

                // Fade in animation
                var fadeIn = new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(300));
                TitleText.BeginAnimation(OpacityProperty, fadeIn);
                ContentText.BeginAnimation(OpacityProperty, fadeIn);
            };

            TitleText.BeginAnimation(OpacityProperty, fadeOut);
            ContentText.BeginAnimation(OpacityProperty, fadeOut);
        }
    }
}
