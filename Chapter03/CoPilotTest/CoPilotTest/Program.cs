// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int CalculateDaysBetweenDates(DateTime startDate, DateTime endDate)
{
    var totalDays = 0;
    for (var currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
    {
        if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
        {
            totalDays++;
        }
    }
    return totalDays;
}
