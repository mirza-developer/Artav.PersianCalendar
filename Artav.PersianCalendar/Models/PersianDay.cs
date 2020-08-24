using System;

namespace Artav.PersianCalendar.Models
{
    public class PersianDay
    {
        public PersianDay()
        {
            IsHoliday = false;
        }
        public PersianWeek PersianWeek { get; set; }
        public bool IsHoliday { get; set; }
        public DateTime GregorianDay { get; set; }
        public string FullDate { get; set; }

    }
}
