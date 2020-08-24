﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artav.PersianCalendar.Logic
{
    public class PersianCalendarTools
    {
        public static string GregorianToPersian(DateTime date)
        {
            var pc = new System.Globalization.PersianCalendar();
            var firstDate = pc.GetYear(date) + "/" + pc.GetMonth(date) + "/" +
                            pc.GetDayOfMonth(date);
            var array = firstDate.Split('/');
            var returnVal = "";
            if (array[1].Length == 1)
                array[1] = "0" + array[1];
            if (array[2].Length == 1)
                array[2] = "0" + array[2];
            for (int i = 0; i < array.Length; i++)
                if (i == 0 | i == 1)
                    returnVal += array[i] + "/";
                else
                    returnVal += array[i];
            return returnVal;
        }

        public static string GregorianDayName(DateTime date)
        {
            var pc = new System.Globalization.PersianCalendar();
            var dayOfWeek = pc.GetDayOfWeek(date);
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "Sunday";
                case DayOfWeek.Monday:
                    return "Monday";
                case DayOfWeek.Tuesday:
                    return "Tuesday";
                case DayOfWeek.Wednesday:
                    return "Wednesday";
                case DayOfWeek.Thursday:
                    return "Thursday";
                case DayOfWeek.Friday:
                    return "Friday";
                case DayOfWeek.Saturday:
                    return "Saturday";
                default:
                    return "Day Week";
            }
        }

        public static string GregorianDayName(int dayNumber)
        {
            var dayOfWeek = dayNumber;
            switch (dayOfWeek)
            {
                case 0:
                    return "Sunday";
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                default:
                    return "Day Week";
            }
        }

        public static string GregorianToPersianWithManualSeprator(DateTime date, string seprator)
        {
            var pc = new System.Globalization.PersianCalendar();
            var firstDate = pc.GetYear(date) + "/" + pc.GetMonth(date) + "/" +
                            pc.GetDayOfMonth(date);
            var array = firstDate.Split('/');
            var returnVal = "";
            if (array[1].Length == 1)
                array[1] = "0" + array[1];
            if (array[2].Length == 1)
                array[2] = "0" + array[2];
            for (int i = 0; i < array.Length; i++)
                if (i == 0 | i == 1)
                    returnVal += array[i] + seprator;
                else
                    returnVal += array[i];
            return returnVal;
        }

        public static string PersianDayName(DateTime date)
        {
            var pc = new System.Globalization.PersianCalendar();
            var dayOfWeek = pc.GetDayOfWeek(date);
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "یکشنبه";
                case DayOfWeek.Monday:
                    return "دوشنبه";
                case DayOfWeek.Tuesday:
                    return "سه شنبه";
                case DayOfWeek.Wednesday:
                    return "چهارشنبه";
                case DayOfWeek.Thursday:
                    return "پنجشنبه";
                case DayOfWeek.Friday:
                    return "جمعه";
                case DayOfWeek.Saturday:
                    return "شنبه";
                default:
                    return "روز هفته";
            }
        }

        /// <summary>
        /// even => 0
        /// Odd => 1
        /// No One => 2
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int PersianOddAndEvenDay(DateTime date)
        {
            var pc = new System.Globalization.PersianCalendar();
            var number = 0;
            var dayOfWeek = pc.GetDayOfWeek(date);
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    number += 1;
                    break;
                case DayOfWeek.Monday:
                    number += 0;
                    break;
                case DayOfWeek.Tuesday:
                    number += 1;
                    break;
                case DayOfWeek.Wednesday:
                    number += 0;
                    break;
                case DayOfWeek.Thursday:
                    number += 1;
                    break;
                case DayOfWeek.Friday:
                    number += 2;
                    break;
                case DayOfWeek.Saturday:
                    number += 0;
                    break;
            }
            return number;
        }

        public static DateTime PersianToGregorian(string date)
        {
            var array = date.Split('/');
            return new DateTime(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]), new System.Globalization.PersianCalendar());
        }

        public static string PersianMonthName(int PersianMonthNumber)
        {
            switch (PersianMonthNumber)
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                case 3:
                    return "خرداد";
                case 4:
                    return "تیر";
                case 5:
                    return "مرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "آبان";
                case 9:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسفند";

            }
            return string.Empty;
        }

        public static string PersianMonthName(DateTime date)
        {
            var monthNumber = GregorianToPersian(date).Split('/')[1];
            switch (int.Parse(monthNumber))
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                case 3:
                    return "خرداد";
                case 4:
                    return "تیر";
                case 5:
                    return "مرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "آبان";
                case 9:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسفند";

            }
            return string.Empty;
        }

        public static bool PersianIsLeap(int PersianYearNumber)
        {
            var pc = new System.Globalization.PersianCalendar();
            return pc.IsLeapYear(PersianYearNumber);
        }

    }
}
