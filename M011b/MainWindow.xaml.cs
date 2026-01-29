using System.Windows;

namespace M011b;

public partial class MainWindow : Window
{
	public static IPage CurrentPage { get; set; }

	private static List<IPage> PreviousPages = [];

	public MainWindow()
	{
		InitializeComponent();
	}

	public static void SwitchPage(string newPage)
	{
		IPage? page = PreviousPages.FirstOrDefault(e => e.Name == newPage);
		if (page != null)
		{
			CurrentPage = page;
			return;
		}

		switch (newPage)
		{
			case "Page1":
				CurrentPage = new Page1();
				break;
		}
	}
}