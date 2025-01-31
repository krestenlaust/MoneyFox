namespace MoneyFox.Ui.Views.Payments.PaymentModification;

using System.Globalization;
using Controls.CategorySelection;
using Resources.Strings;

public class NoCategorySelectedConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value is not SelectedCategoryViewModel category ? Translations.SelectCategoryLabel : category.Name;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}
