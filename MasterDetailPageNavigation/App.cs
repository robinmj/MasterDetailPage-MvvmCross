using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
	{
		public override void Initialize()
		{
			RegisterAppStart<ViewModels.MainViewModel>();
		}
	}
}

