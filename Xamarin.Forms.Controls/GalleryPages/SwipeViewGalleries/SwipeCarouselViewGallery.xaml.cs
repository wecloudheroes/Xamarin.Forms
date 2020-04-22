﻿using Xamarin.Forms.Internals;

namespace Xamarin.Forms.Controls.GalleryPages.SwipeViewGalleries
{
	[Preserve(AllMembers = true)]
	public partial class SwipeCarouselViewGallery : ContentPage
	{
		public SwipeCarouselViewGallery()
		{
			InitializeComponent();
			BindingContext = new SwipeViewGalleryViewModel();

			MessagingCenter.Subscribe<SwipeViewGalleryViewModel, object>(this, "favourite", (sender, args) =>
			{
				DisplayAlert("SwipeView", $"Favourite {((Message)args).Title}", "Ok");
			});

			MessagingCenter.Subscribe<SwipeViewGalleryViewModel, object>(this, "delete", (sender, args) =>
			{
				DisplayAlert("SwipeView", $"Delete {((Message)args).Title}", "Ok");
			});
		}
	}
}