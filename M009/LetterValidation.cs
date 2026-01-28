using System.Globalization;
using System.Windows.Controls;

namespace M009;

class LetterValidation : ValidationRule
{
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string eingabe = (string)value;
		if (eingabe != null && !eingabe.All(char.IsLetter))
			return new ValidationResult(false, "Alle Zeichen müssen Buchstaben sein!");

		return ValidationResult.ValidResult;
	}
}
