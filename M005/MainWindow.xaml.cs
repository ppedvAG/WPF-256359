using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace M005;

public partial class MainWindow : Window, INotifyPropertyChanged
{
	private int counter = 3;

	/// <summary>
	/// Wenn eine Backend Variable gebunden werden soll, MUSS diese ein Property sein (get; set;)
	/// </summary>
	public int Counter
	{
		get => counter;
		set
		{
			counter = value;
			//Notify(nameof(Counter));
			Notify(); //Nach [CallerMemberName]
		}
	}

	/// <summary>
	/// ObservableCollection
	/// 
	/// Liste, die über Änderungen von sich selbst benachrichtigt
	/// </summary>
	public ObservableCollection<int> Zahlen { get; set; } = [];

	public MainWindow()
	{
		InitializeComponent();

		//this.DataContext = this;
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Counter++;

		//Notify("Counter");

		//////////////////////////////////////

		//WICHTIG: ObservableCollection darf niemals neu erstellt werden
		//Collection entleeren und neu befüllen (Zahlen.Clear())
		//Zahlen = new ObservableCollection<int>();

		Zahlen.Add(Random.Shared.Next());
	}

	///////////////////////////////////////////////////////////////////////

	/// <summary>
	/// INotifyPropertyChanged
	/// 
	/// Benachrichtigungsmechanismus
	/// Wenn sich im Backend etwas ändert, kann die Notify Methode verwendet werden, um eine Benachrichtigung zu senden
	/// Sollte generell beim Property selbst aufgerufen werden
	/// </summary>
	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
}