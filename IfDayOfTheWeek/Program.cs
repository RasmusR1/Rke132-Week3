
int WeekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(WeekDay);

if (WeekDay == 0)
{
    Console.WriteLine("On Pühapäev!");
}
else if (WeekDay == 1)
{
    Console.WriteLine("On Esmaspäev!");
}
else if (WeekDay == 2)
{
    Console.WriteLine("On Teisipäev!");
}
else if (WeekDay == 3)
{
    Console.WriteLine("On Kolmapäev!");
}
else if (WeekDay == 4)
{
    Console.WriteLine("On Neljapäev!");
}
else if (WeekDay == 5)
{
    Console.WriteLine("On Reede!");
}
else 
{
    Console.WriteLine("On Laupäev!");
}

Console.WriteLine("Hyva Päeva");