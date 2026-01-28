using System.ComponentModel;
using System.Windows;

namespace M009;

public partial class MainWindow : Window, IDataErrorInfo
{
	public string Vorname { get; set; }

	private string nachname;

	public string Nachname
	{
		get => nachname;
		set
		{
			if (!value.All(char.IsLetter))
				throw new Exception("Alle Zeichen müssen Buchstaben sein!");

			if (value.Length < 3 || value.Length > 15)
				throw new Exception("Nachname muss zw. 3 und 15 Zeichen haben!");

			nachname = value;
		}
	}

	public string ZweiterVorname { get; set; }

	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{

	}

	////////////////////////////////////////////////////////////

	public string Error => throw new NotImplementedException(); //Für uns irrelevant

	public string this[string prop]
	{
		get
		{
			switch (prop)
			{
				case nameof(ZweiterVorname):
					if (ZweiterVorname == null)
						return null;
					
					if (!ZweiterVorname.All(char.IsLetter))
						return ("Alle Zeichen müssen Buchstaben sein!");

					if (ZweiterVorname.Length < 3 || ZweiterVorname.Length > 15)
						return ("Nachname muss zw. 3 und 15 Zeichen haben!");

					return null;
			}

			return null; //Alles OK
		}
	}
}