using System;

using HubSender.Services;
using HubSender.Views;

using Xamarin.Forms;

namespace HubSender.ViewModels
{
	public class HubSettingsViewModel : BaseViewModel
	{
		public HubSettingsViewModel()
		{
			Title = "Hub settings";
		}


		public string NotificationHubName
		{
			get => Application.Current.Properties.TryGetValue(HubSettings.NotificationHubNameKey, out var keyValue) ? keyValue.ToString() : String.Empty;
			set => Application.Current.Properties[HubSettings.NotificationHubNameKey] = value;
		}

		public string FullAccessConnectionString
		{
			get => Application.Current.Properties.TryGetValue(HubSettings.FullAccessConnectionStringKey, out var keyValue) ? keyValue.ToString() : String.Empty;
			set => Application.Current.Properties[HubSettings.FullAccessConnectionStringKey] = value;
		}
	}
}