using System.Globalization;
using System.Windows.Data;

namespace M004;

class ScoreToGradeConverter : IValueConverter //Strg + .: Schnelloptionen anzeigen
{
	/// <summary>
	/// Convert: Quelle zu Ziel
	/// Slider -> TextBlock
	/// Double -> String
	/// </summary>
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		//string note;
		//double d = (double) value;
		//switch (d)
		//{
		//	case < 50:
		//		note = "Nicht Genügend";
		//		break;
		//	case < 60:
		//		note = "Mangelhaft";
		//		break;
		//	case < 70:
		//		note = "Ausreichend";
		//		break;
		//	case < 80:
		//		note = "Befriedigend";
		//		break;
		//	case < 90:
		//		note = "Gut";
		//		break;
		//	case <= 100:
		//		note = "Sehr Gut";
		//		break;
		//	default:
		//		note = "Unbekannt";
		//		break;
		//}
		//return note + $" ({d})";

		double d = (double) value;
		return d switch
		{
			< 50 => "Nicht Genügend",
			< 60 => "Mangelhaft",
			< 70 => "Ausreichend",
			< 80 => "Befriedigend",
			< 90 => "Gut",
			<= 100 => "Sehr Gut",
			_ => "Unbekannt",
		} + $" ({d})";
	}

	/// <summary>
	/// Ziel -> Quelle
	/// String -> Double
	/// Hier nicht notwendig, weil der TextBlock nicht verändert werden kann
	/// </summary>
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}