using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artav.PersianCalendar.Logic
{
    public static class DateTimeExtensions
    {
        public static string ToPersianShortDateString(this DateTime dateTime)
        {
            return PersianCalendarTools.GregorianToPersian(dateTime);
        }
        public static string ToPersianLongDateString(this DateTime dateTime)
        {
            var converted = PersianCalendarTools.GregorianToPersian(dateTime).Split('/');
            return PersianCalendarTools.PersianDayName(dateTime) + " " + converted[2] + ""+PersianCalendarTools.PersianMonthName(dateTime)+" " + converted[0];
        }
    }
}
