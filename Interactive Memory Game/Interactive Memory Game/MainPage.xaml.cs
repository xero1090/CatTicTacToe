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
        private const int IMAGE_TILE_COUNT = 8;
        private Game _game;
        private Image _imgTileCtrlList;
        private Image _imgMatchCtrlList;
        private Image _imgTile1;
        private Image _imgTile2;
        private Image _imgTile3;
        private Image _imgTile4;
        private Image _imgTile5;
        private Image _imgTile6;
        private Image _imgTile7;
        private Image _imgTile8;

        public MainPage(Image tileCtrlList, Image matchCtrlList)
        {
            _imgTileCtrlList = tileCtrlList;
            _imgMatchCtrlList = matchCtrlList;
        }
        public MainPage()
        {
            this.InitializeComponent();
            player = new MediaPlayer();
            _game = new Game();
            _imgTile1 = new Image();
            _imgTile2 = new Image();
            _imgTile3 = new Image();
            _imgTile4 = new Image();
            _imgTile5 = new Image();
            _imgTile6 = new Image();
            _imgTile7 = new Image();
            _imgTile8 = new Image();
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
