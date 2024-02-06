using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
        private MatchedImage[] images; // Array to store MatchedImage controls
        private int[] imageMatches; // Array to store matching information
        private int firstClickedIndex = -1; // Index of the first clicked image
        private int matchedCount = 0; // Keep track of the number of matched images

        public Game()
        {
            this.InitializeComponent();
            InitializeArrays();
        }

        private void InitializeArrays()
        {
            // Initialize the arrays with MatchedImage controls and matching information
            images = new MatchedImage[] { new MatchedImage { ImageControl = _laser1 }, new MatchedImage { ImageControl = _pig1 }, new MatchedImage { ImageControl = _nuke1 }, new MatchedImage { ImageControl = _nom1 }, new MatchedImage { ImageControl = _nuke2 }, new MatchedImage { ImageControl = _laser2 }, new MatchedImage { ImageControl = _nom2 }, new MatchedImage { ImageControl = _pig2 } };
            imageMatches = new int[images.Length];

            // Initialize matching information (for demonstration purposes)
            for (int i = 0; i < imageMatches.Length; i++)
            {
                imageMatches[i] = i % (imageMatches.Length / 2);
            }
            // Shuffle the matching information
            ShuffleArray(imageMatches); 
        }
        private void OnTapped(object sender, TappedRoutedEventArgs e)
        {
            Image tappedImage = sender as Image;

            if (tappedImage != null)
            {
                // Handle tapping if needed
            }
        }
        private async void OnButtonClick(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                int buttonIndex = Convert.ToInt32(clickedButton.Tag) - 1; // Tags are 1-based

                // Reveal the image
                MatchedImage matchedImage = images[buttonIndex];
                matchedImage.ImageControl.Source = new BitmapImage(new Uri($"ms-appx:///Assets/{imageMatches[buttonIndex]}.jpg"));

                

                if (firstClickedIndex == -1)
                {
                    // First button clicked
                    firstClickedIndex = buttonIndex;
                }
                else
                {
                    // Second button clicked
                    await Task.Delay(250);
                    if (imageMatches[firstClickedIndex] == imageMatches[buttonIndex])
                    {
                        // Match
                        ShowMatchPopup();
                        matchedCount++;

                        // Mark the images as matched
                        images[firstClickedIndex].IsMatched = true;
                        images[buttonIndex].IsMatched = true;

                        // Check if all images are matched after this match
                        if (matchedCount == images.Length / 2)
                        {
                            // Navigate to GameOver page
                            this.Frame.Navigate(typeof(GameOver));
                            return; // Exit the method to prevent further processing
                        }
                    }
                    else
                    {
                        // No match
                        ShowNoMatchPopup();
                        // Optionally, reset the images here
                        ResetImages();
                    }
                    // Reset for the next pair
                    firstClickedIndex = -1; 
                }
            }
        }

        private void ShowMatchPopup()
        {
            // Show the match popup
            MessageDialog matchDialog = new MessageDialog("You have a match!");
            _ = matchDialog.ShowAsync();

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
            // Reset only the images that have not been matched
            for (int i = 0; i < images.Length; i++)
            {
                if (!images[i].IsMatched)
                {
                    images[i].ImageControl.Source = new BitmapImage(new Uri("ms-appx:///Assets/question mark.png"));
                }
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



