using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using M014.Model;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace M014.ViewModel;

public partial class PersonViewViewModel : ObservableObject
{
	[ObservableProperty]
	private ObservableCollection<Person> personen;

	public PersonViewViewModel()
	{
		string readJson = File.ReadAllText(@"..\..\..\Personen.json");
		Personen = new ObservableCollection<Person>(JsonSerializer.Deserialize<List<Person>>(readJson)!);
	}

	[RelayCommand]
	private void PersonLoeschen(object o)
	{
		Person p = o as Person;
		Personen.Remove(p);
	}

	//DependencyInjection: Add-Methoden in App.xaml, Angreifen über App.Current.Services (Anmeldung von C#-Klassen)
	//WeakReferenceMessenger: Senden von Nachrichten zwischen Views/Pages, übertragen von Daten
}