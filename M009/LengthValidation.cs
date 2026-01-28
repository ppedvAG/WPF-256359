using System.Globalization;
using System.Windows.Controls;

namespace M009;

class LengthValidation : ValidationRule
{
	public int Min { get; set; } = 3;

	public int Max { get; set; } = 15;

	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string eingabe = (string)value;
		if (eingabe != null && eingabe.Length < Min || eingabe.Length > Max)
			return new ValidationResult(false, $"Die Eingabe muss zw. {Min} und {Max} Zeichen haben!");

		return ValidationResult.ValidResult;
	}
}
