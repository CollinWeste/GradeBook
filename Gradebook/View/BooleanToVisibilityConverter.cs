// Copyright Collin Westenhaver 2017
// GradeBook +++

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Gradebook.View
{
  public class BooleanToVisibilityConverter : MarkupExtension, IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return value as bool? ?? false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return null;
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
      return this;
    }
  }
}
