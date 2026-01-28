using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace M009;

class ValidationBindingExtension : MarkupExtension
{
	public Binding Binding { get; set; }

	public ValidationRule Rule1 { get; set; }

	public ValidationRule Rule2 { get; set; }

	public ValidationRule Rule3 { get; set; }

	public ValidationRule Rule4 { get; set; }

	public Collection<ValidationRule> Rules { get; set; }

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (Rule1 != null)
			Binding.ValidationRules.Add(Rule1);

		if (Rule2 != null)
			Binding.ValidationRules.Add(Rule2);

		if (Rule3 != null)
			Binding.ValidationRules.Add(Rule3);

		if (Rule4 != null)
			Binding.ValidationRules.Add(Rule4);

		if (Rules != null)
			foreach (ValidationRule r in Rules)
				Binding.ValidationRules.Add(r);

		return Binding.ProvideValue(serviceProvider); //Führe das Binding weiterhin normal aus
	}
}
