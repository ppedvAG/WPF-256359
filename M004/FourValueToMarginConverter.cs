using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace M004;

class FourValueToMarginConverter : IMultiValueConverter
{
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		//double[] zahlen = new double[values.Length];
		//for (int i = 0; i < zahlen.Length; i++)
		//{
		//	zahlen[i] = (double)values[i];
		//}
		//Thickness t = new Thickness(zahlen[0], zahlen[1], zahlen[2], zahlen[3]);
		//return t;

		double[] z = values.Select(e => (double) e).ToArray();
		return new Thickness(z[0], z[1], z[2], z[3]);
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
