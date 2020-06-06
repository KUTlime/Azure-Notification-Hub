using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using HubSender.Services;

using Microsoft.Azure.NotificationHubs;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HubSender.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Send : ContentPage
	{
		private UInt16 _messageCount = UInt16.MinValue;
		private NotificationHubClient _hub;

		public Send()
		{
			InitializeComponent();
		}

		private async void BtnSendNotificationAsync(object sender, EventArgs e)
		{
			if (!(sender is Button btnSend))
			{
				return;
			}

			btnSend.IsEnabled = false;
			btnSend.Text = "Sending";
			var templateParameters = new Dictionary<string, string>() { ["messageParam"] = MessageText.Text };
			try
			{
				_hub = HubProvider.GetHub();
				foreach (var tag in Tag.Text.Split(';', ' ', ' '))
				{
					UserLog.Text += $"Sending notification #{++_messageCount} to {tag} category subscribers!\n";
					var t = await Task.Run(
						async () => await _hub.SendTemplateNotificationAsync(templateParameters, tag));
					UserLog.Text += $"The notification has been sent to {tag} subscribers. State: {t.State}\n";
				}
			}
			catch (Exception exception)
			{
				UserLog.Text += $"Sending failed!\n{exception.Message}\n";
			}
			finally
			{
				btnSend.Text = "Send";
				btnSend.IsEnabled = true;
			}

		}
	}
}