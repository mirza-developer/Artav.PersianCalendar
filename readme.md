# Artav.PersianCalendar

A Library for converting date & time , year calendar generate in Persian Calendar 
Written in .net Framework 4.0


## Usage
1- Generate full year calendar by year number

```C#
var cg = new PersianCalendarGenerator();
var cal = cg.CreateYearCalendar(1399/*Enter your year number*/); // returns a PersianYear 
```
2- Generate Calendar of a Month 

```C#
var cg = new PersianCalendarGenerator();
var month = cg.GetMonth(1399/*Enter your year number*/,2); // returns list of PersianMonth
```
3- Get persian date on DateTime 
```C#
DateTime.Now.ToPersianLongDateString(); // Returns a string like 'دوشنبه 03شهریور 1399'
DateTime.Now.ToPersianShortDateString(); // Returns a string like '1399/06/03'
```
4- Convert tool
```C#
// Convert to Persian
PersianCalendarTools.GregorianToPersian(DateTime date); // Returns a string like '1399/06/03'
PersianCalendarTools.GregorianToPersianWithManualSeprator(DateTime date, string seprator); // Returns a string like '1399-06-03' with custom seprator

// Get Gregorian day name
PersianCalendarTools.GregorianDayName(DateTime date); // Returns a string like 'Monday'
PersianCalendarTools.GregorianDayName(int dayNumber); // Returns a string like 'Monday'

// Get Persian day name
PersianCalendarTools.PersianDayName(DateTime date); // Returns a string like 'دوشنبه'

// Get Persian day even/odd status
PersianCalendarTools.PersianOddAndEvenDay(DateTime date); // Returns an int value ,0 means even,1 means odd and 2 means no one

// Convert to Gregorian
PersianCalendarTools.PersianToGregorian(string persianDate); // Returns converted DateTime value

// Get Persian Month name
PersianCalendarTools.PersianMonthName(int PersianMonthNumber); // Returns a string like 'فروردین'
PersianCalendarTools.PersianMonthName(DateTime date); // Returns a string like 'فروردین'

// Check 4 years leap
PersianCalendarTools.PersianIsLeap(int PersianYearNumber); // Returns a bool , if year is leap

```


## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
