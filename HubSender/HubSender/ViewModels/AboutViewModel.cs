using System.Reflection;
using System.Windows.Input;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace HubSender.ViewModels
{
	public class AboutViewModel : BaseViewModel
	{
		public AboutViewModel()
		{
			Title = "About";
			OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/KUTlime/Azure-Notification-Hub"));

		}

		public ICommand OpenWebCommand { get; }

		public string VersionNumber { get; } = VersionTracking.CurrentVersion;

		public string BuildNumber { get; } = VersionTracking.CurrentBuild;
	}
}