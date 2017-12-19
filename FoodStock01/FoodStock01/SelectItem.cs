using System;
using System.Globalization;
using Xamarin.Forms;

namespace FoodStock01
{
    public class SelectedItem : IValueConverter
    {
        public object Convert(object value,Type targetType,object parameter,CultureInfo culture)
        {
            var args = (SelectedItem)value;
            return args.SelectedItem;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}