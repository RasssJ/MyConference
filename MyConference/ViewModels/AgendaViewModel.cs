using CommunityToolkit.Mvvm.Input;
using MvvmHelpers;
using MyConference.Models;

namespace MyConference.ViewModels;

public partial class AgendaViewModel : ObservableObject
{
    public ObservableRangeCollection<Grouping<string, Session>> Agenda { get; } = new();

    public AgendaViewModel() 
    {
    
    }

    [RelayCommand]
    Task LoadDataAsync()
    {
        return Task.CompletedTask;
    }
}
