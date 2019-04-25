using System;
using System.Diagnostics;
using System.Net.Sockets;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xamurai
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

#if DEBUG
			try
			{
				// NOTE: For android, make sure to run 'adb forward tcp:8000 tcp:8000' command - you'll need to do this if you've restarted your machine
				HotReloader.Current.Start(this);
			}
			catch (SocketException)
			{
				Debug.WriteLine("Cannot start hot-reload: make sure another app isn't open on the device listening on the same port");
				Debugger.Break();
			}
#endif


			MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
