MasterDetailPage with MvvmCross-Forms
=====================================

In order to work through some issues I encountered while adding MasterDetailPage to an existing app, I have adapted the
 [MasterDetailPage](https://github.com/xamarin/xamarin-forms-samples/tree/master/Navigation/MasterDetailPage)
 Xamarin.Forms example to be an MvvmCross-Forms project.
 
### Notes

* I haven't adapted the iOS project (yet)
* I encountered difficulties getting MvvmCross-Forms to build under the wpa81 target, so the Windows Phone project is targeted to wp81.
* Due to differences in the original example and the [MvvmCross-Forms sample](https://github.com/MvvmCross/MvvmCross-Forms/tree/ac3f1e77822b562ec9650f7974b6f2235d18dfc1/Samples/Example001CSharp) I used as a reference, the UI in Windows Phone still doesn't look like the original example.