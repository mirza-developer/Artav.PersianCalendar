using System.Collections.Generic;

namespace Artav.PersianCalendar.Models
{
    public class PersianMonth
    {
        public int MonthNumber { get; set; }
        public List<PersianWeek> ListWeeks { get; set; }

    }
}
