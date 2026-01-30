using System.Windows.Input;

namespace M014;

public class CustomCommand : ICommand
{
	private Action<object> _execute;

	private Func<object, bool> _canExecute;

	/// <summary>
	/// Wenn das Command erzeugt wird, müssen hier zwei Methodenzeiger übergeben werden
	/// 
	/// Diese Methodenzeiger werden dann unten in den Execute und CanExecute Methoden verwendet
	/// </summary>
	public CustomCommand(Action<object> execute, Func<object, bool> canExecute)
	{
		ArgumentNullException.ThrowIfNull(execute);

		_execute = execute;
		_canExecute = canExecute;
	}

	///////////////////////////////////////////////////////

	public event EventHandler? CanExecuteChanged;

	public void Execute(object? parameter)
	{
		_execute.Invoke(parameter);
	}

	public bool CanExecute(object? parameter)
	{
		if (_canExecute == null)
			return true;

		return _canExecute.Invoke(parameter);
	}
}
