using System;
using HubSender.Models;
using Microsoft.Azure.NotificationHubs;

using Xamarin.Forms;

namespace HubSender.Services
{
	internal class HubProvider
	{
		public static NotificationHubClient GetHub()
		{
			Application.Current.Properties.TryGetValue(HubSettings.FullAccessConnectionStringKey, out var connectionString);// ? connectionString?.ToString() ?? String.Empty : String.Empty
			Application.Current.Properties.TryGetValue(HubSettings.NotificationHubNameKey, out var name);
			return NotificationHubClient.CreateClientFromConnectionString(
				connectionString?.ToString() ?? String.Empty,
				name?.ToString() ?? String.Empty
			);
		}
	}
}