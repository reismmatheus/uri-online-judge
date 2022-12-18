using System;

class URI
{
    static void Main(string[] args)
    {
        var readLines = Console.ReadLine().Split(' ');
        var startDay = int.Parse(readLines[1]);

        readLines = Console.ReadLine().Split(' ');
        var startHour = int.Parse(readLines[0]);
        var startMinutes = int.Parse(readLines[2]);
        var startSeconds = int.Parse(readLines[4]);

        readLines = Console.ReadLine().Split(' ');
        var endDate = int.Parse(readLines[1]);

        readLines = Console.ReadLine().Split(' ');
        var endHour = int.Parse(readLines[0]);
        var endMinutes = int.Parse(readLines[2]);
        var endSeconds = int.Parse(readLines[4]);

        var initial = (startDay - 1) * (24 * 60 * 60) + (startHour * 60 * 60) + (startMinutes * 60) + startSeconds;
        var final = (endDate - 1) * (24 * 60 * 60) + (endHour * 60 * 60) + (endMinutes * 60) + endSeconds;

        var duration = final - initial;

        var days = duration / (24 * 60 * 60);
        var rest = duration % (24 * 60 * 60);
        var hours = rest / (60 * 60);
        rest %= (60 * 60);
        var minutes = rest / 60;
        var seconds = rest % 60;

        Console.WriteLine($"{days} dia(s)");
        Console.WriteLine($"{hours} hora(s)");
        Console.WriteLine($"{minutes} minuto(s)");
        Console.WriteLine($"{seconds} segundo(s)");
    }
}