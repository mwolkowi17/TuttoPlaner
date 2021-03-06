﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuttoPlaner.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuttoPlaner
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DayDetails : ContentPage
    {
        public DayDetails(Day day)
        {
            if (day == null)
                throw new ArgumentNullException();
            BindingContext = day;
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as Button;
            var dayToUpdate = menuItem.CommandParameter as Day;
            await Navigation.PushAsync(new DayUpdate(dayToUpdate));
        }
    }
}