using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace M011;

public partial class ColorSlider : UserControl
{
	public string Text
	{
		get => (string) GetValue(TextProperty);
		set => SetValue(TextProperty, value);
	}

	public static readonly DependencyProperty TextProperty =
		DependencyProperty.Register
		(
			nameof(Text), //Name des Properties dahinter
			typeof(string), //Typ des Properties dahinter
			typeof(ColorSlider) //Typ der Klasse, in dem das Property enthalten ist
			//new FrameworkPropertyMetadata(0) //Konfigurationseinstellungen
		);

	////////////////////////////////////////////////////////////////////////////////////////////

	public Color TextColor
	{
		get => (Color) GetValue(TextColorProperty);
		set => SetValue(TextColorProperty, value);
	}

	public static readonly DependencyProperty TextColorProperty =
		DependencyProperty.Register(nameof(TextColor), typeof(Color), typeof(ColorSlider), new PropertyMetadata(Colors.Black));

	////////////////////////////////////////////////////////////////////////////////////////////

	public double SliderValue
	{
		get => (double) GetValue(SliderValueProperty);
		set => SetValue(SliderValueProperty, value);
	}

	public static readonly DependencyProperty SliderValueProperty =
		DependencyProperty.Register(nameof(SliderValue), typeof(double), typeof(ColorSlider), new PropertyMetadata(0.0));

	public ColorSlider()
	{
		InitializeComponent();
	}
}