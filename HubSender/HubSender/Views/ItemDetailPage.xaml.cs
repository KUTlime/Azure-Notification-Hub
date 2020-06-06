﻿using System.ComponentModel;
using Xamarin.Forms;
using HubSender.Models;
using HubSender.ViewModels;

namespace HubSender.Views
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class ItemDetailPage : ContentPage
	{
		readonly ItemDetailViewModel _viewModel;

		public ItemDetailPage(ItemDetailViewModel viewModel)
		{
			InitializeComponent();

			BindingContext = _viewModel = viewModel;
		}

		public ItemDetailPage()
		{
			InitializeComponent();

			var item = new Item
			{
				Text = "Item 1",
				Description = "This is an item description."
			};

			_viewModel = new ItemDetailViewModel(item);
			BindingContext = _viewModel;
		}
	}
}