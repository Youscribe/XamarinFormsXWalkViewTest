using Xamarin.Forms;

namespace XWalkViewFormsApp
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			//MainPage = new ContentPage {
			//	Content = new StackLayout {
			//		VerticalOptions = LayoutOptions.FillAndExpand,
			//		Children = {
   //                     new WebViewEx { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Url = "https://www.google.com" }
   //                 }
   //             }
   //         };
            MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
