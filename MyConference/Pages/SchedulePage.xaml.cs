using MyConference.ViewModels;

namespace MyConference.Pages;

[QueryProperty(nameof(Day), nameof(Day))]
public partial class SchedulePage : ContentPage
{
	readonly ScheduleViewModel vm;
	int day;
	public int Day 
	{
		get => day;
		set
		{
			day = value;
			vm.Day = day;
		}
	}
    public SchedulePage(ScheduleViewModel vm)
	{
		InitializeComponent();

		BindingContext = this.vm = vm;

	}

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
		if (vm.Schedule.Count == 0)
            await vm.LoadDataCommand.ExecuteAsync(null);
    }
}