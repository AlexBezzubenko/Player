using System;
using System.Resources;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TestApp.Model;
using TestApp.Properties;

namespace TestApp.Converters
{
    public class SliderValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            var p = (Playlist)value;
               
            var t = p.CurrentTrack;
            int position = 0;
            if (t != null)
            {
                double pos = (p.Player.Position.Ticks / t.TrackLength.Ticks) * 100;

                position = (int)pos;
            }
            return position;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }

    public class RateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            string FileName = @"pack://siteoforigin:,,,/Res/rate";
            if ((int)value > -1 && (int)value < 6)
            {
                var res = FileName + ((int)value).ToString() + ".png";
                return new BitmapImage(new Uri(res));
            }
            else
            {
                return new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Res/rate0.png"));                
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }

    public class MyConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType,
               object parameter, System.Globalization.CultureInfo culture)
        {
            
            return values.Clone();
        }
        public object[] ConvertBack(object value, Type[] targetTypes,
               object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Cannot convert back");
        }
    }

    public class LangConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType,
               object parameter, System.Globalization.CultureInfo culture)
        {

            return values.Clone();
        }
        public object[] ConvertBack(object value, Type[] targetTypes,
               object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Cannot convert back");
        }
    }
}