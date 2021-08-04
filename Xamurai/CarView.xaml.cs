using Prism.Commands;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;

namespace Xamurai
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarView : ContentView, INotifyPropertyChanged
	{
		public CarView ()
		{
			IsExpanded = true;
			ToggleCollapseCommand = new DelegateCommand(ToggleCollapse);
			InitializeComponent ();
		}

		private void ToggleCollapse()
		{
			//if (DeviceInfo.Platform == DevicePlatform.Android)
			//{
				//BUG iOS pre7+: doesn't collapse the section, only makes the label invisible
				IsExpanded = !IsExpanded;
				OnPropertyChanged(nameof(IsExpanded));
			//}
		}

		public ICommand ToggleCollapseCommand { get; }

		public bool IsExpanded { get; set; }
	}
}