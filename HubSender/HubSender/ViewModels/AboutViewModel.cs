using System.Windows.Input;

using Xamarin.Essentials;
using Xamarin.Forms;

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
	}
}