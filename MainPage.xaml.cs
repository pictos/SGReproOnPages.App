using CommunityToolkit.Mvvm.ComponentModel;

namespace SGReproOnPages;

//Uncomment the line below to see the other error


//[INotifyPropertyChanged]
public partial class MainPage : ContentPage
{
	[ObservableProperty]
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

