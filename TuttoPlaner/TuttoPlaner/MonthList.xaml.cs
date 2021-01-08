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
    public partial class MonthList : ContentPage
    {
        public MonthList()
        {
            InitializeComponent();

            var months = new List<Month>
            {
                new Month {MonthId=1, MonthName="January" },
                new Month {MonthId=2, MonthName="February" },
                new Month {MonthId=1, MonthName="March" },
                new Month {MonthId=1, MonthName="Aprill" },
                new Month {MonthId=1, MonthName="May" },
                new Month {MonthId=1, MonthName="March" },
                new Month {MonthId=1, MonthName="July" },
                new Month {MonthId=1, MonthName="August" },
                new Month {MonthId=1, MonthName="September" },
                new Month {MonthId=1, MonthName="October" },
                new Month {MonthId=1, MonthName="November"},
                new Month {MonthId=1, MonthName="December" }
            };

            monthsList.ItemsSource = months;
        }

        private void monthsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var monthToDisplay = e.SelectedItem as Month;
            Navigation.PushAsync(new MonthDetails(monthToDisplay));
        }
    }
}