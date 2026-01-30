namespace M014.ViewModel;

public class MainWindowViewModel : ViewModelBase
{
	private int counter;

	public int Counter
	{
		get => counter;
		set
		{
			counter = value;
			Notify(nameof(Counter));
		}
	}

	public CustomCommand CounterCommand { get; set; }

	public MainWindowViewModel()
	{
		CounterCommand = new CustomCommand(CounterIncrement, null);
	}

	public void CounterIncrement(object o)
	{
		Counter++;
	}
}