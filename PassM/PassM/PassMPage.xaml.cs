using System;
using Xamarin.Forms;

namespace PassM
{
	public partial class PassMPage : ContentPage
	{
		public PassMPage()
		{
			InitializeComponent();
		}

		async void doLogin(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ListCategory(this));
		}
	}
}

