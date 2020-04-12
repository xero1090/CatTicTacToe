using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Interactive_Memory_Game
{
    public enum TileStatus
    {
        Hidden = 1,
        Revealed,
        Match
    }
    public class Tile   
    {
        private Image _imageCtrl;
        private TileStatus _status;
        private BitmapImage s_imgCoverSource;
        private BitmapImage _imgSource;
        private BitmapImage _imgSourceList;
        public Tile()
        {
            _status = new TileStatus();
        }
        public Tile(BitmapImage imageCover, BitmapImage imgSource, BitmapImage sourceList)
        {
            s_imgCoverSource = imageCover;
            _imgSource = imgSource;
            _imgSourceList = sourceList;
        }
        public Tile(Image imgctrl)
        {
            _imageCtrl = imgctrl;
        }
      
        public void Reveal() {  }
        public void Hide() { }
        

    }
   
}
