﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MasterDetailPageNavigation.WindowsPhone.Resources;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Views;
using MvvmCross.Forms.Presenter.WindowsPhone;
using Xamarin.Forms.Platform.WinPhone;

namespace MasterDetailPageNavigation.WindowsPhone
{
    public partial class MainPage : FormsApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            var presenter = Mvx.Resolve<IMvxViewPresenter>() as MvxFormsWindowsPhonePagePresenter;
            LoadApplication(presenter.MvxFormsApp);
        }
    }
}