using CommunityToolkit.Mvvm.Input;
using MvvmHelpers;
using MyConference.Models;
using Jeffsum;
using static Jeffsum.Goldblum;

namespace MyConference.ViewModels;

public partial class AgendaViewModel : ObservableObject
{
    public int Day { get; set; }
    public ObservableRangeCollection<Grouping<string, Session>> Agenda { get; } = new();
    Random random = new ();
    public AgendaViewModel() 
    {
    
    }

    [RelayCommand]
    Task LoadDataAsync()
    {
        var sessioncount = new[] { 1, 2, 4, 4, 4, 4, 4, };
        var sessions = new List<Session>();
        var start = new DateTime(2022, 9, Day, 8, 30, 0);

        for (int i = 0; i < sessioncount.Length; i++)
            AddItems(sessioncount[i], i);

        return Task.CompletedTask;

        void AddItems(int count)
        {
            for (int i = 0; i < count; i++) 
            {
                sessions.Add(new Session
                {
                    Title = string.Join(" ", ReceiveTheJeff(random.Next(2, 5), JeffsumType.Words)),
                    Description = ReceiveTheJeff(1).First(),
                    Room = "Goldblum",
                    Start = start.AddHours(offset),
                    End = start.AddHours(offset + 1)
                });

            }
        }
    }
}
