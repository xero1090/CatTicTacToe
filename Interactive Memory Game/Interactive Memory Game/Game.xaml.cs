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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Interactive_Memory_Game
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Game : Page
    {
        MessageDialog Match = new MessageDialog("You've got a match!");

        MessageDialog Win = new MessageDialog("You've won!");
        
        MessageDialog No_Match = new MessageDialog("Thats not a match.");

        Image first_image;

        Image second_image;

        Image clickedImage;

        bool clicked;
        int score;
        public Game()
        {
            this.InitializeComponent();
            first_image = null;
            second_image = null;
            clickedImage = null;
            score = 0;
            clicked = false;
           
        }

        private async void Pairs_Match()
       {
            //if both images are the same then display the Match Pop-up
           if (first_image.Source == second_image.Source)
           { 
                //show the Match Pop-up
               await Match.ShowAsync();
           }
      }

        private async void Pairs_DontMatch()
        { 
            //if both images aren't the same then display the No_Match Pop-up
            if (first_image.Source != second_image.Source)
            {
                //show the No_Match Pop-up
                await No_Match.ShowAsync();
            }
        }

        private async void Congrats()
        {
            //if all Images have been clicked then display the Win Pop-up (counter only increases for each unclicked image)
            if (score == 8)
            {//show the Win Pop-up
                await Win.ShowAsync();
            }
        }

        private bool IsClicked()
        {
            //if the image is clicked it cannot be clicked anymore
            if (clicked)
            {
                return clicked = true;
            }
            //However if the image has not been clicked then it will add a point when clicked
            else
            {
                return clicked = false;
            }
        }
        private void OnClick1(object sender, RoutedEventArgs e)

        {
            //whenever this button is clicked change the image to the desired image
            _laser1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Laser cat.jpg"));
            clickedImage = sender as Image;
            IsClicked();
            if (IsClicked() == false)
            {
                //if this is the first time this image is clicked then add a point
                score++;
                //if the first image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the first image
                if (first_image == null)
                {
                    first_image = clickedImage;

                }
                //if the second image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the second image
                if (second_image == null)
                {
                second_image = clickedImage;
                }
                //if both image choices are not empty then compare and see if they match or dont match 
                if (first_image !=null && second_image != null)
                {
                Pairs_Match();
                Pairs_DontMatch();
                }

            }
            //if the points or the score (same thing) are 8 then the user (in theory) 
            //has matched all the images and the Win Pop-up appears
            Congrats();
        }

        private void OnClick2(object sender, RoutedEventArgs e)
        {
            //whenever this button is clicked change the image to the desired image
            _pig1.Source = new BitmapImage(new Uri("ms-appx:///Assets/pigacorn.jpg"));
            clickedImage = sender as Image;
            IsClicked();
            if (IsClicked() == false)
            {
                //if this is the first time this image is clicked then add a point
                score++;
                //if the first image is empty (image is essentially a choice) then the image
                //that was just clicked will become the first image
                if (first_image == null)
                {
                    first_image = clickedImage;

                }
                //if the second image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the second image
                if (second_image == null)
                {
                    second_image = clickedImage;
                }
                //if both image choices are not empty then compare and see if they match or dont match 
                if (first_image != null && second_image != null)
                {
                    Pairs_Match();
                    Pairs_DontMatch();
                }
            }

            //if the points or the score (same thing) are 8 then the user (in theory) 
            //has matched all the images and the Win Pop-up appears
            Congrats();
        }

        private void OnClick3(object sender, RoutedEventArgs e)
        {
            //whenever this button is clicked change the image to the desired image
            _nuke1.Source = new BitmapImage(new Uri("ms-appx:///Assets/nuke cat.jpg"));
            clickedImage = sender as Image;
            IsClicked();
            if (IsClicked() == false)
            {
                //if this is the first time this image is clicked then add a point
                score++;
                //if the first image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the first image
                if (first_image == null)
                {
                    first_image = clickedImage;

                }
                //if the second image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the second image
                if (second_image == null)
                {
                    second_image = clickedImage;
                }
                //if both image choices are not empty then compare and see if they match or dont match 
                if (first_image != null && second_image != null)
                {
                    Pairs_Match();
                    Pairs_DontMatch();
                }
            }
            //if the points or the score (same thing) are 8 then the user (in theory) 
            //has matched all the images and the Win Pop-up appears
            Congrats();

        }

        private void OnClick4(object sender, RoutedEventArgs e)
        {
            //whenever this button is clicked change the image to the desired image
            _nom1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Omnom Cat.jpg"));
            clickedImage = sender as Image;

            IsClicked();
            if (IsClicked() == false)
            {
                //if this is the first time this image is clicked then add a point
                score++;
                //if the first image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the first image
                if (first_image == null)
                {
                    first_image = clickedImage;

                }
                //if the second image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the second image
                if (second_image == null)
                {
                    second_image = clickedImage;
                }
                //if both image choices are not empty then compare and see if they match or dont match 
                if (first_image != null && second_image != null)
                {
                    Pairs_Match();
                    Pairs_DontMatch();
                }
            }

            //if the points or the score (same thing) are 8 then the user (in theory) 
            //has matched all the images and the Win Pop-up appears
            Congrats();
        }

        private void OnClick5(object sender, RoutedEventArgs e)
        {
            //whenever this button is clicked change the image to the desired image
            _nuke2.Source = new BitmapImage(new Uri("ms-appx:///Assets/nuke cat.jpg"));
            clickedImage = sender as Image;
            IsClicked();
            if (IsClicked() == false)
            {
                //if this is the first time this image is clicked then add a point
                score++;
                //if the first image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the first image
                if (first_image == null)
                {
                    first_image = clickedImage;

                }
                //if the second image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the second image
                if (second_image == null)
                {
                    second_image = clickedImage;
                }
                //if both image choices are not empty then compare and see if they match or dont match 
                if (first_image != null && second_image != null)
                {
                    Pairs_Match();
                    Pairs_DontMatch();
                }
            }
            //if the points or the score (same thing) are 8 then the user (in theory) 
            //has matched all the images and the Win Pop-up appears
            Congrats();
        }
        private void OnClick6(object sender, RoutedEventArgs e)
        {
            //whenever this button is clicked change the image to the desired image
            _laser2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Laser cat.jpg"));
            clickedImage = sender as Image;

            IsClicked();
            if (IsClicked() == false)
            {
                //if this is the first time this image is clicked then add a point
                score++;
                //if the first image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the first image
                if (first_image == null)
                {
                    first_image = clickedImage;

                }
                //if the second image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the second image
                if (second_image == null)
                {
                    second_image = clickedImage;
                }
                //if both image choices are not empty then compare and see if they match or dont match 
                if (first_image != null && second_image != null)
                {
                    Pairs_Match();
                    Pairs_DontMatch();
                }
            }
            //if the points or the score (same thing) are 8 then the user (in theory) 
            //has matched all the images and the Win Pop-up appears
            Congrats();

        }

        private void OnClick7(object sender, RoutedEventArgs e)
        {
            //whenever this button is clicked change the image to the desired image
            _nom2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Omnom Cat.jpg"));
            clickedImage = sender as Image;
            IsClicked();
            if (IsClicked() == false)
            {
                //if this is the first time this image is clicked then add a point
                score++;
                //if the first image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the first image
                if (first_image == null)
                {
                    first_image = clickedImage;

                }
                //if the second image is empty (image is essentially a choice) then the image
                //that was just clicked will become the second image
                if (second_image == null)
                {
                    second_image = clickedImage;
                }
                //if both image choices are not empty then compare and see if they match or dont match 
                if (first_image != null && second_image != null)
                {
                    Pairs_Match();
                    Pairs_DontMatch();
                }
            }
            //if the points or the score (same thing) are 8 then the user (in theory) 
            //has matched all the images and the Win Pop-up appears
            Congrats();
        }

        private void OnClick8(object sender, RoutedEventArgs e)
        {
            //whenever this button is clicked change the image to the desired image
            _pig2.Source = new BitmapImage(new Uri("ms-appx:///Assets/pigacorn.jpg"));
            clickedImage = sender as Image;
            IsClicked();
            if (IsClicked() == false)
            {
                //if this is the first time this image is clicked then add a point
                score++;
                //if the first image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the first image
                if (first_image == null)
                {
                    first_image = clickedImage;

                }
                //if the second image is empty (image is essentially a choice) then the image 
                //that was just clicked will become the second image
                if (second_image == null)
                {
                    second_image = clickedImage;
                }
                //if both image choices are not empty then compare and see if they match or dont match 
                if (first_image != null && second_image != null)
                {
                    Pairs_Match();
                    Pairs_DontMatch();
                }
            }
            //if the points or the score (same thing) are 8 then the user (in theory)
            //has matched all the images and the Win Pop-up appears
            Congrats();
        }

        //Just ignore this section I have no idea why but when I removed this I had an error and despite removing the elements in Game.g.cs
        //It still interfered with my Matching logic
        private void OnTapped(object sender, TappedRoutedEventArgs e)
        {
           
                clickedImage = sender as Image;
                // If Image is null assign it to a new image when clicked
                if (clickedImage == null)
                { }

                if (first_image == null)
                {
                    first_image = clickedImage;

                }
            // If Second Image is null assign it to a new image when clicked
            if (second_image == null)
                {
                    second_image = clickedImage;

                }
            
        } 
        
    }
    

   
        
    }

