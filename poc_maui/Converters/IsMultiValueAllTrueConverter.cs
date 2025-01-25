using System.Globalization;

namespace poc_maui.Converters
{
    public class IsMultiValueAllTrueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Length == 0)
            {
                return false;
            }

            foreach (var value in values)
            {
                if (value is not bool boolValue || !boolValue)
                {
                    return false;
                }
            }

            return true;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("ConvertBack is not supported in IsMultiValueAllTrueConverter.");
        }
    }
}

