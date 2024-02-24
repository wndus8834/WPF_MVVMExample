using System.ComponentModel;
using MVVMExample.Models;

namespace MVVMExample.ViewModels
{
	public class MainViewModel : INotifyPropertyChanged
	{
		private DataModel _data;

		public MainViewModel()
		{
			_data = new DataModel();
		}

		public DataModel Data
		{
			get { return _data; }
			set
			{
				if (_data != value)
				{
					_data = value;
					OnPropertyChanged(nameof(Data));
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
