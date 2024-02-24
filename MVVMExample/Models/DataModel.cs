using System.ComponentModel;

namespace MVVMExample.Models
{
	public class DataModel : INotifyPropertyChanged
	{
		private double _number;

		public double Number
		{
			get { return _number; }
			set
			{
				if (_number != value)
				{
					_number = value;
					OnPropertyChanged(nameof(Number));
					OnPropertyChanged(nameof(DoubledNumber));
				}
			}
		}

		public double DoubledNumber => Number * 2;

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
