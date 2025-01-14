﻿
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerProblemiOSRelease
{
    public class RegistrationBackgroundColorHeaderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return parameter.ToString() == "2" ? 
            (Color)Application.Current.Resources["ButtonDisabledBackgroundColor"]:
            (Color)Application.Current.Resources["ButtonEnabledBackgroundColor"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
