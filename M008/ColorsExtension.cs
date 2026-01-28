using System.Windows.Markup;
using System.Windows.Media;

namespace M008;

public class ColorsExtension : MarkupExtension
{
	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		//List<NamedColor> colors = [];
		//foreach (PropertyInfo pi in typeof(Colors).GetProperties())
		//{
		//	NamedColor nc = new NamedColor();
		//	nc.Name = pi.Name;
		//	nc.Color = (Color) pi.GetValue(null)!; //null als Parameter, weil alle Felder in Colors static sind
		//	colors.Add(nc);
		//}
		//return colors;

		return typeof(Colors).GetProperties().Select(e => new NamedColor() { Name = e.Name, Color = (Color) e.GetValue(null) });
	}
}

public class NamedColor
{
	public string Name { get; set; }

	public Color Color { get; set; }

	public Brush Brush => new SolidColorBrush(Color);

	public string HexCode => Color.ToString();
}
