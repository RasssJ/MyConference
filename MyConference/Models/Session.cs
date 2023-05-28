namespace MyConference.Models;

public class Session
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Room { get; set; }
    public string Description { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string StartTimeDisplay => $"{Start:t}";
    public string DayDisplay => $"{Start:MMM} {Start:d}";
}
