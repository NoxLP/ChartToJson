﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ChartCanvasNamespace.Converters
{
    public class BrushColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return null;

            if (value is SolidColorBrush)
                return ((SolidColorBrush)value).Color;

            throw new InvalidOperationException("Unsupported type [" + value.GetType().Name + "], ColorToSolidColorBrushValueConverter.ConvertBack()");
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return null;

            if (value is Color)
                return new SolidColorBrush((Color)value);

            throw new InvalidOperationException("Unsupported type [" + value.GetType().Name + "], ColorToSolidColorBrushValueConverter.Convert()");
        }
    }
}
