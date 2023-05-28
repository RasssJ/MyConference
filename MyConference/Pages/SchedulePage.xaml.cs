using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class SchedulePage : ContentPage
{
	ScheduleViewModel vm;

    public SchedulePage(ScheduleViewModel vm)
	{
		InitializeComponent();

		switch(Title)
		{
			case "Day 1":
				vm.Day = 1;
				break;
			case "Day 2":
				vm.Day = 2;
				break;
		}

		BindingContext = this.vm = vm;

	}

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
		if (vm.Schedule.Count == 0)
            await vm.LoadDataCommand.ExecuteAsync(null);
    }
}