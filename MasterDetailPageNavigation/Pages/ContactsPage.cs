using Xamarin.Forms;

namespace MasterDetailPageNavigation.Pages
{
	public class ContactsPage : ContentPage
	{
		public ContactsPage ()
		{
			Title = "Contacts Page";
			Content = new StackLayout { 
				Children = {
					new Label {
						Text = "Contacts data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}
