using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;
using MvvmCross.Forms.Presenter.Core;
using MvvmCross.Forms.Presenter.Windows81;
using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.WindowsCommon.Platform;
using Cirrious.MvvmCross.WindowsCommon.Views;
using Microsoft.Phone.Controls;
using Xamarin.Forms;

namespace MasterDetailPageNavigation.WindowsPhone
{
    public class Setup : MvxPhoneSetup
    {
        public Setup(PhoneApplicationFrame rootFrame) : base(rootFrame)
        {
        }

        protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp()
        {
            return new Example.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IMvxPhoneViewPresenter CreateViewPresenter(PhoneApplicationFrame rootFrame)
        {
            Forms.Init();

            var xamarinFormsApp = new MvxFormsApp();
            var presenter = new MvxFormsWindowsPhonePagePresenter(rootFrame, xamarinFormsApp);
            Mvx.RegisterSingleton<IMvxViewPresenter>(presenter);

            return presenter;
        }
    }
}