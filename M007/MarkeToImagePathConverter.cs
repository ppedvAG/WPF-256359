using System.Globalization;
using System.IO;
using System.Windows.Data;

namespace M007;

public class MarkeToImagePathConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		FahrzeugMarke m = (FahrzeugMarke) value;
		string folderPath = "C:\\Users\\lk3\\source\\repos\\WPF_2026_01_27\\M007\\Images\\";
		return Path.Combine(folderPath, m.ToString().ToLower() + ".png");
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
}