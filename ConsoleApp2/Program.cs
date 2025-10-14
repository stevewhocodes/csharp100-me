/*
 * Creating a new DateTime value
 * DateTime.Now - current system date + time
 * DateTime.Today - Current system date + Midnight
 * DateTime.UtcNow - current system date + UTC time (for time zone neutral)
 *
 * new DateTime(year, month, day)
 * new DateTime(year, month, day, hour, minute, second)
 */

DateTime d1 = DateTime.Now;
DateTime d2 = new DateTime(2022, 1, 5); // January 5, 2022, 00:00:00
DateTime d3 = new DateTime(2022, 1, 5, 14, 30, 45); //January 5, 2022, 2:30:45PM
Console.WriteLine(d1.Ticks); // Ticks are the base storage unit

/* Parsing
 * 
 * DateTime.Parse() and DateTime.TryParse()
 * Any valid culture format works.  For example:
 * 1/5/2022
 * 1/5/2022 14:30:45
 * Wed Jan 5, 2022
 */

DateTime d4 = DateTime.Parse("1/5/2022 14:30:45");
Console.WriteLine(d4);
d4 = DateTime.Parse("Thu Jan 6, 2022");
Console.WriteLine(d4);

/* TimeSpan Type
 *
 * Can add or subtract values from dates and is used to calculate differences
 * new TimeSpan(days, hours, minutes, seconds)
 * new TimeSpan(hours, minutes, seconds)
 *
 * Negative values can go backwards in time
 */

TimeSpan ts = d1.Subtract(d3);
Console.WriteLine($"{ts.Days}d, {ts.Hours}h {ts.Minutes}m {ts.Seconds}s");

ts = new TimeSpan(5, 12, 0, 0); // 5 days, 12 hours

