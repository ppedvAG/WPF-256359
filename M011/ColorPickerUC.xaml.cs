using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace M011;

public partial class ColorPickerUC : UserControl
{
	public double R
	{
		get { return (double) GetValue(RProperty); }
		set { SetValue(RProperty, value); }
	}

	public static readonly DependencyProperty RProperty =
		DependencyProperty.Register(nameof(R), typeof(double), typeof(ColorPickerUC), new FrameworkPropertyMetadata(0.0, SliderValueChanged));


	public double G
	{
		get { return (double) GetValue(GProperty); }
		set { SetValue(GProperty, value); }
	}

	public static readonly DependencyProperty GProperty =
		DependencyProperty.Register(nameof(G), typeof(double), typeof(ColorPickerUC), new PropertyMetadata(0.0, SliderValueChanged));


	public double B
	{
		get { return (double) GetValue(BProperty); }
		set { SetValue(BProperty, value); }
	}

	public static readonly DependencyProperty BProperty =
		DependencyProperty.Register(nameof(B), typeof(double), typeof(ColorPickerUC), new PropertyMetadata(0.0, SliderValueChanged));


	public double A
	{
		get { return (double) GetValue(AProperty); }
		set { SetValue(AProperty, value); }
	}

	public static readonly DependencyProperty AProperty =
		DependencyProperty.Register(nameof(A), typeof(double), typeof(ColorPickerUC), new PropertyMetadata(255.0, SliderValueChanged));

	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public Color PickedColor
	{
		get => (Color) GetValue(PickedColorProperty);
		set => SetValue(PickedColorProperty, value);
	}

	public static readonly DependencyProperty PickedColorProperty =
		DependencyProperty.Register(nameof(PickedColor), typeof(Color), typeof(ColorPickerUC), new PropertyMetadata(PickedColorChanged));

	//Aufgabe: Methode definieren, die bei jeder Änderung von einem Slider ausgeführt wird, und die Farbe neu berechnet
	//Delegate: Effektiv ein Methodenzeiger mit einem konkreten Aufbau (wird von dem Delegate selbst vorgegeben)
	//Der Methodenzeiger muss diesen Aufbau haben, weil das Delegate diesen Aufbau verlangt
	public static void SliderValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		//Alle 4 Werte auslesen, die Gesamtfarbe berechnen, und diese in PickedColor hinein schreiben
		byte a = (byte) (double) d.GetValue(AProperty); //d: Das UserControl selbst
		byte r = (byte) (double) d.GetValue(RProperty);
		byte g = (byte) (double) d.GetValue(GProperty);
		byte b = (byte) (double) d.GetValue(BProperty);

		Color color = Color.FromArgb(a, r, g, b);

		d.SetValue(PickedColorProperty, color);
	}

	//Farbe aus MainWindow übernehmen und in die Slider eintragen
	public static void PickedColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		Color c = (Color) d.GetValue(PickedColorProperty);

		d.SetValue(AProperty, (double) c.A);
		d.SetValue(RProperty, (double) c.R);
		d.SetValue(GProperty, (double) c.G);
		d.SetValue(BProperty, (double) c.B);
	}

	public ColorPickerUC()
	{
		InitializeComponent();
	}
}
