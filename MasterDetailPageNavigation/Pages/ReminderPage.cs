using Xamarin.Forms;

namespace MasterDetailPageNavigation.Pages
{
	public class ReminderPage : ContentPage
	{
		public ReminderPage ()
		{
			Title = "Reminder Page";
			Content = new StackLayout { 
				Children = {
					new Label {
						Text = "Reminder data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}
