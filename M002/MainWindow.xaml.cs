using System.Windows;

namespace M002;

public partial class MainWindow : Window
{
	public int Counter;

	public MainWindow()
	{
		InitializeComponent();

		Dropdown.ItemsSource = Enumerable.Range(0, 10);

		LB.ItemsSource = Enum.GetValues<DayOfWeek>();
	}

	/// <summary>
	/// Strg R + R: Name ändern, wird überall angepasst
	/// </summary>
	private void CounterIncrement(object sender, RoutedEventArgs e)
	{
		Counter++;
		CounterText.Text = Counter.ToString();
	}

	private void EingabeBestaetigen(object sender, RoutedEventArgs e)
	{
		CounterText.Text = Eingabe.Text;
	}

	private void CheckBox_Checked(object sender, RoutedEventArgs e)
	{

	}

	private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
	{

	}

	private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		SliderOutput.Text = e.NewValue.ToString();
	}

	private void MenuItem_Click(object sender, RoutedEventArgs e)
	{
		MessageBoxResult result = MessageBox.Show("Möchtest du ein neues Projekt erstellen?", "Projekt erstellen", MessageBoxButton.YesNo, MessageBoxImage.Question);
		if (result == MessageBoxResult.Yes)
		{
			//...
		}

		if (result == MessageBoxResult.No)
		{
			//...
		}
	}
}