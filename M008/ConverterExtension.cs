using System.Windows.Data;
using System.Windows.Markup;

namespace M008;

class ConverterExtension : MarkupExtension
{
	public Type ConverterType { get; set; }

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (ConverterType == null)
			throw new ArgumentNullException("Der gegebene Typ ist null");

		if (ConverterType.GetInterface(nameof(IValueConverter)) == null)
			throw new ArgumentException("Der gegebene Typ ist kein IValueConverter");

		return Activator.CreateInstance(ConverterType);
	}
}
