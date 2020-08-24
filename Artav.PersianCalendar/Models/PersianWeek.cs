using System.Collections.Generic;

namespace Artav.PersianCalendar.Models
{
    public class PersianWeek
    {
        public int WeekNumber { get; set; }
        public List<PersianDay> ListDays { get; set; }
        public PersianMonth PersianMonth { get; set; }
    }
}
