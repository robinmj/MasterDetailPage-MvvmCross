using Xamarin.Forms;

namespace MasterDetailPageNavigation.Pages
{
	public class TodoListPage : ContentPage
	{
		public TodoListPage ()
		{
			Title = "TodoList Page";
			Content = new StackLayout { 
				Children = {
					new Label {
						Text = "Todo list data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}
