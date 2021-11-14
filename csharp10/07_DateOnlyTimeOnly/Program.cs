var dateOnly = new DateOnly(2021, 12, 20);
Console.WriteLine(dateOnly); // Output: 20.12.2021

var timeOnly = new TimeOnly(20, 15, 30);
Console.WriteLine(timeOnly); // Output: 20:15

var timeOnlyParsed = TimeOnly.Parse("23:00");
var timeOnlyParsed2 = TimeOnly.Parse("8:00 AM");