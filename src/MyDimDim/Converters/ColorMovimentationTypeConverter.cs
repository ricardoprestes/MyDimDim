using System;
using System.Globalization;
using Xamarin.Forms;

namespace MyDimDim.Converters
{
    public class ColorMovimentationTypeConverter : IValueConverter
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
                    return Application.Current.Resources["ColorExpense"];
                case Enums.EMovimentationType.Revenue:
                    return Application.Current.Resources["ColorRevenue"];
                default:
                    return Application.Current.Resources["ColorTransfer"];
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
