using System;

using HubSender.Models;
using HubSender.Services;

using Xamarin.Forms;

namespace HubSender.ViewModels
{
	public class SendViewModel : BaseViewModel
	{
		public SendViewModel()
		{
			Title = "Notification dispatcher";
		}

		public string SubscriberTag
		{
			get => Application.Current.Properties.TryGetValue(NotificationSettings.TagKey, out var keyValue) ? keyValue.ToString() : String.Empty;
			set => Application.Current.Properties[NotificationSettings.TagKey] = value;
		}

		public string NotificationMessage
		{
			get => Application.Current.Properties.TryGetValue(NotificationSettings.MessageKey, out var keyValue) ? keyValue.ToString() : String.Empty;
			set => Application.Current.Properties[NotificationSettings.MessageKey] = value;
		}
	}
}