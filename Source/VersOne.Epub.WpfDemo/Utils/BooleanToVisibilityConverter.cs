﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace VersOne.Epub.WpfDemo.Utils
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool))
            {
                return Visibility.Hidden;
            }
            if ((bool)value)
            {
                return Visibility.Visible;
            }
            else if (parameter != null)
            {
                return Visibility.Collapsed;
            }
            else
            {
                return Visibility.Hidden;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
