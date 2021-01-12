using SQLite;
using System;
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
        private SQLiteAsyncConnection _connection;
        public MonthList()
        {
            InitializeComponent();
           _connection=DependencyService.Get<ISQLiteDb>().GetConnection();
           
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

        protected override async void OnAppearing()
        
        {
            await _connection.CreateTableAsync<Month>();
            var testmonth = new Month { MonthName = "January" };
            await _connection.InsertAsync(testmonth);
            
            base.OnAppearing();
        }

        private async void  monthsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var monthToDisplay = e.SelectedItem as Month;
            await Navigation.PushAsync(new MonthDetails(monthToDisplay));
            monthsList.SelectedItem = null;
        }
    }
}