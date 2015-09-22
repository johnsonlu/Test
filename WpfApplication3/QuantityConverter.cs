namespace WpfApplication3
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    using QuantityTypes;

    [ValueConversion(typeof(IQuantity), typeof(string))]
    public class QuantityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && targetType == typeof(string))
            {
                return string.Format(UnitProvider.Default, "{0}", value);
            }

            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (typeof(IQuantity).IsAssignableFrom(targetType))
            {
                if (value == null)
                {
                    return DependencyProperty.UnsetValue;
                }

                IQuantity q;
                if (UnitProvider.Default.TryParse(targetType, value.ToString(), culture, out q))
                {
                    return q;
                }
            }

            return DependencyProperty.UnsetValue;
        }
    }
}
