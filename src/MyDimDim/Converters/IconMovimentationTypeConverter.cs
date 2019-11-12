using System;
using System.Globalization;
using Xamarin.Forms;

namespace MyDimDim.Converters
{
    public class IconMovimentationTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            var statusInt = System.Convert.ToInt32(value);
            var status = (Enums.EMovimentationType)statusInt;
            switch (status)
            {
                case Enums.EMovimentationType.Expense:
                    return "arrow_up";
                case Enums.EMovimentationType.Revenue:
                    return "arrow_down";
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
