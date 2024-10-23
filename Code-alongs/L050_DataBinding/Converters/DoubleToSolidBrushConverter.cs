using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace L050_DataBinding.Converters
{
    internal class DoubleToSolidBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var myByte = System.Convert.ToByte(value);

            var myColor = new Color() { R = myByte, G = myByte, B = myByte, A = 255 };

            return new SolidColorBrush(myColor);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
