using System.Windows.Markup;

namespace M008;

public class EnumExtension : MarkupExtension
{
	public Type EnumType { get; set; }

	/// <summary>
	/// Wenn die GUI den Wert aus der MarkupExtension ({ }) anfordert, wird diese Methode ausgeführt
	/// Der Rückgabewert dieser Methode, wird dann in der GUI eingesetzt
	/// </summary>
	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (EnumType == null)
			throw new ArgumentNullException("Der gegebene Typ ist null");

		if (!EnumType.IsEnum)
			throw new ArgumentException("Der angegebene Typ ist kein Enum");

		return Enum.GetValues(EnumType);
	}
}
