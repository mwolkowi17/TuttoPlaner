﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuttoPlaner
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MonthList())
            {
                BarBackgroundColor = Color.Orange
        };
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
