﻿using appeufiz.Services;
using appeufiz.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appeufiz
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());


        }

    protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
