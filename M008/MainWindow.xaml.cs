using System.Windows;
using System.Windows.Media;

namespace M008;

public partial class MainWindow : Window
{
	public DayOfWeek[] Wochentage { get; set; } = Enum.GetValues<DayOfWeek>();

	public DayOfWeek SelectedDay { get; set; }

	public Color SelectedColor { get; set; }

	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{

	}
}