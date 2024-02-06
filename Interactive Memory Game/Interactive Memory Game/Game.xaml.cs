using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;



namespace Interactive_Memory_Game
{

    public sealed partial class Game : Page
    {
        private Image[] images; // Array to store Image controls
        private int[] imageMatches; // Array to store matching information
        private int firstClickedIndex = -1; // Index of the first clicked image

        public Game()
        {
            this.InitializeComponent();
            InitializeArrays();
        }

        private void InitializeArrays()
        {
            // Initialize the arrays with Image controls and matching information
            images = new Image[] { _laser1, _pig1, _nuke1, _nom1, _nuke2, _laser2, _nom2, _pig2 };
            imageMatches = new int[images.Length];

            // Initialize matching information (for demonstration purposes)
            for (int i = 0; i < imageMatches.Length; i++)
            {
                imageMatches[i] = i % (imageMatches.Length / 2);
            }

            ShuffleArray(imageMatches); // Shuffle the matching information
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                int buttonIndex = Convert.ToInt32(clickedButton.Tag) - 1; // Tags are 1-based

                // Reveal the image
                Image image = images[buttonIndex];
                image.Source = new BitmapImage(new Uri($"ms-appx:///Assets/{imageMatches[buttonIndex]}.jpg"));

                if (firstClickedIndex == -1)
                {
                    // First button clicked
                    firstClickedIndex = buttonIndex;
                }
                else
                {
                    // Second button clicked
                    if (imageMatches[firstClickedIndex] == imageMatches[buttonIndex])
                    {
                        // Match
                        ShowMatchPopup();
                    }
                    else
                    {
                        // No match
                        ShowNoMatchPopup();
                        // Optionally, reset the images here
                        ResetImages();
                    }

                    firstClickedIndex = -1; // Reset for the next pair
                }
            }
        }

        private void OnTapped(object sender, TappedRoutedEventArgs e)
        {
            Image tappedImage = sender as Image;

            if (tappedImage != null)
            {
                // Handle tapping if needed
            }
        }

        private void ShowMatchPopup()
        {
            // Show the match popup
            MessageDialog matchDialog = new MessageDialog("You have a match!");
            _ = matchDialog.ShowAsync();

            // Optionally,
            // Update score or any other game logic as needed
        }

        private void ShowNoMatchPopup()
        {
            // Show the no match popup
            MessageDialog noMatchDialog = new MessageDialog("Sorry, the tiles do not match. Please try again.");
            _ = noMatchDialog.ShowAsync();

            // Optionally, reset the images here
            ResetImages();
        }

        private void ResetImages()
        {
            // Reset all images to question mark
            foreach (Image image in images)
            {
                image.Source = new BitmapImage(new Uri("ms-appx:///Assets/question mark.png"));
            }
        }

        // Fisher-Yates shuffle algorithm for shuffling an array
        private void ShuffleArray<T>(T[] array)
        {
            Random random = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

    }
}
