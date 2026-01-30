using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace M013;

public partial class MainWindow : Window
{
	public ExitCommand Exit { get; set; } = new();

	public CustomCommand CustomExit { get; set; }

	public CustomCommand EnterCommand { get; set; }

	public MainWindow()
	{
		CustomExit = new CustomCommand(ExitMethod, CanExitMethod);
		EnterCommand = new CustomCommand(EnterPressed, null);

		InitializeComponent();
	}

	public void ExitMethod(object o)
	{
		Close();
	}

	public bool CanExitMethod(object o)
	{
		if (o != null)
			return (bool) o;
		return false;
	}

	public void EnterPressed(object o)
	{
		KeyEventArgs a = (KeyEventArgs) o;
		if (a.Key == Key.Enter)
			Output.Text = TB.Text;
	}
}