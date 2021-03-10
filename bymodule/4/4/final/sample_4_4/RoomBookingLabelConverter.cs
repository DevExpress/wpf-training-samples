using System;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Markup;

namespace sample_4_4 {
  public class RoomBookingLabelConverter : MarkupExtension, IValueConverter {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
      return value == null ? "room not booked" : "room booked";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
      throw new NotImplementedException();
    }

    public override object ProvideValue(IServiceProvider serviceProvider) {
      return this;
    }
  }
}