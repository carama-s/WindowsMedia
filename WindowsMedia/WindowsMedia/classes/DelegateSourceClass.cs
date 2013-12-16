﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsMedia.classes
{
    public class DelegateSourceClass
    {
        public void PlaylistSource(MainWindow win)
        {
            win.GridMusicFilters.Visibility = System.Windows.Visibility.Hidden;
        }
        public void MusicSource(MainWindow win)
        {
            win.GridMusicFilters.Visibility = System.Windows.Visibility.Visible;
            win.clickStyle_ = ClickStyle.MUSIC;
            win.MainBox.ItemsSource = win.musicLib_;
        }
        public void ImageSource(MainWindow win)
        {
            win.GridMusicFilters.Visibility = System.Windows.Visibility.Hidden;
        }
        public void VideoSource(MainWindow win)
        {
            win.GridMusicFilters.Visibility = System.Windows.Visibility.Hidden;
            win.clickStyle_ = ClickStyle.VIDEO;
            win.MainBox.ItemsSource = win.movieLib_;
        }
    }
}
