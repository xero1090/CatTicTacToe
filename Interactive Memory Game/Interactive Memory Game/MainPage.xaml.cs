using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Playback;
using Windows.Media.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Interactive_Memory_Game
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // Declare our Windows Media Player
        MediaPlayer player;

        public MainPage()
        {
            this.InitializeComponent();
            player = new MediaPlayer();
        }

        private async void OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Game));
            
            // Searches within the Assets Folder
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");

            // Searches for specific file
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Dog of Wisdom Remix.mp3");

            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();
        }

        private void ToEnd(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GameOver));
        }
    }
}
