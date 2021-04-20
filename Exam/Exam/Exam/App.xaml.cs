﻿using Exam.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exam
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new OnStartup());
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
