using System.Reflection;
using System.Windows.Controls;
using System.Windows.Markup;

namespace M009;

class RuleExtension : MarkupExtension
{
	public Type RuleType { get; set; }

	public object Data1 { get; set; }

	public object Data2 { get; set; }

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (RuleType == null)
			throw new ArgumentNullException("Der gegebene Typ ist null");

		if (RuleType.BaseType != typeof(ValidationRule))
			throw new ArgumentException("Der gegebene Typ ist keine ValidationRule");

		object rule = Activator.CreateInstance(RuleType);

		PropertyInfo[] array = rule.GetType().GetProperties();
		for (int i = 0; i < 2; i++)
		{
			array[i].SetValue(rule,  Convert.ChangeType(i == 0 ? Data1 : Data2, array[i].PropertyType), null);
		}

		return rule;
	}
}
