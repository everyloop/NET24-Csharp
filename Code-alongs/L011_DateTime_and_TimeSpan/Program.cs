Console.WriteLine("*** DateTime *****************");
Console.WriteLine();

Console.WriteLine($"DateTime.MinValue => {DateTime.MinValue}");
Console.WriteLine($"DateTime.MaxValue => {DateTime.MaxValue}");
Console.WriteLine($"DateTime.UtcNow => {DateTime.UtcNow}");
Console.WriteLine($"DateTime.Now => {DateTime.Now}");
Console.WriteLine($"DateTime.Today => {DateTime.Today}");

Console.WriteLine();

DateTime myDateTime = new DateTime(2019, 10, 3, 13, 12, 15);
Console.WriteLine($"myDateTime = {myDateTime}");
Console.WriteLine();

Console.WriteLine($"myDateTime.Year = {myDateTime.Year}");
Console.WriteLine($"myDateTime.Month = {myDateTime.Month}");
Console.WriteLine($"myDateTime.Day = {myDateTime.Day}");
Console.WriteLine($"myDateTime.Hour = {myDateTime.Hour}");
Console.WriteLine($"myDateTime.Minute = {myDateTime.Minute}");
Console.WriteLine($"myDateTime.Second = {myDateTime.Second}");
Console.WriteLine($"myDateTime.DayOfWeek = {myDateTime.DayOfWeek}");
Console.WriteLine($"myDateTime.DayOfYear = {myDateTime.DayOfYear}");

Console.WriteLine($"myDateTime.AddYears(5) = {myDateTime.AddYears(5)}");
Console.WriteLine($"myDateTime.AddMinutes(10) = {myDateTime.AddMinutes(10)}");

myDateTime = myDateTime.AddYears(5).AddMonths(2).AddHours(5);
Console.WriteLine();
Console.WriteLine($"myDateTime = {myDateTime}");

Console.WriteLine();
Console.WriteLine("*** DateTime *****************");
Console.WriteLine();

TimeSpan myTimeSpan = new TimeSpan(5, 10, 4, 3);
Console.WriteLine($"myTimeSpan = {myTimeSpan}");
Console.WriteLine();

Console.WriteLine($"myDateTime = {myDateTime}");
Console.WriteLine($"DateTime.Now = {DateTime.Now}");
Console.WriteLine($"myDateTime.Subtract(DateTime.Now) = {myDateTime.Subtract(DateTime.Now)}");











