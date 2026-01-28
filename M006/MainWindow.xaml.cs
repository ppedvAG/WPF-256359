using System.Windows;

namespace M006;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();

		//Resources im Backend angreifen
		Output.Text = this.Resources["DefaultBackgroundColor"].ToString();
	}
}