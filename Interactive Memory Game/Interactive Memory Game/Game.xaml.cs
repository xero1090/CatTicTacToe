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
        public Game()
        {
            this.InitializeComponent();
        }


        private void OnClick1(object sender, RoutedEventArgs e)

        {
            _laser1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Laser cat.jpg"));
        }

        private void OnClick2(object sender, RoutedEventArgs e)
        {
            _pig1.Source = new BitmapImage(new Uri("ms-appx:///Assets/pigacorn.jpg"));
        }

        private void OnClick3(object sender, RoutedEventArgs e)
        {
            _nuke1.Source = new BitmapImage(new Uri("ms-appx:///Assets/nuke cat.jpg"));
        }

        private void OnClick4(object sender, RoutedEventArgs e)
        {
            _nom1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Omnom cat.jpg"));
        }

        private void OnClick5(object sender, RoutedEventArgs e)
        {
            _nuke2.Source = new BitmapImage(new Uri("ms-appx:///Assets/nuke cat.jpg"));
        }
        private void OnClick6(object sender, RoutedEventArgs e)
        {
            _laser2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Laser cat.jpg"));
        }
        private void OnClick7(object sender, RoutedEventArgs e)
        {
            _nom2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Omnom cat.jpg"));
        }

        private void OnClick8(object sender, RoutedEventArgs e)
        {
            _pig2.Source = new BitmapImage(new Uri("ms-appx:///Assets/pigacorn.jpg"));
        }
    }
}
