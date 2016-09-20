using Xamarin.Forms;

namespace PassM
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			var fPage = new PassMPage();
			MainPage = new NavigationPage(new PassMPage());
			NavigationPage.SetBackButtonTitle(fPage, "Test");
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

