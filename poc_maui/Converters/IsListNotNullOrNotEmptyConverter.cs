using System.Collections;
using System.Globalization;

namespace poc_maui.Converters
{
    public class IsListNotNullOrNotEmptyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is IList list)
            {
                return list?.Count > 0;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("ConvertBack is not supported in IsListNotNullOrNotEmptyConverter.");
        }
    }
}

