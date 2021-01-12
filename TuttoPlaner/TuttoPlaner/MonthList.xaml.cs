using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Month> _listtodisplay;
        public MonthList()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();




        }

        protected override async void OnAppearing()

        {
            await _connection.CreateTableAsync<Month>();
            var testmonth1 = new Month { MonthName = "January" };
            var testmonth2 = new Month { MonthName = "February" };
            var testmonth3 = new Month { MonthName = "March" };
            var testmonth4 = new Month { MonthName = "Aprill" };
            var testmonth5 = new Month { MonthName = "May" };
            var testmonth6 = new Month { MonthName = "March" };
            var testmonth7 = new Month { MonthName = "July" };
            var testmonth8 = new Month { MonthName = "August" };
            var testmonth9 = new Month { MonthName = "September" };
            var testmonth10 = new Month { MonthName = "October" };
            var testmonth11 = new Month { MonthName = "November" };
            var testmonth12 = new Month { MonthName = "December" };
            List<Month> robocza = await _connection.Table<Month>().ToListAsync();
            if (robocza.Count() == 0)
            {


                await _connection.InsertAsync(testmonth1);
                await _connection.InsertAsync(testmonth2);
                await _connection.InsertAsync(testmonth3);
                await _connection.InsertAsync(testmonth4);
                await _connection.InsertAsync(testmonth5);
                await _connection.InsertAsync(testmonth6);
                await _connection.InsertAsync(testmonth7);
                await _connection.InsertAsync(testmonth8);
                await _connection.InsertAsync(testmonth9);
                await _connection.InsertAsync(testmonth10);
                await _connection.InsertAsync(testmonth11);
                await _connection.InsertAsync(testmonth12);
            }
            var listtodisplay = await _connection.Table<Month>().ToListAsync();
            _listtodisplay = new ObservableCollection<Month>(listtodisplay);
            /*for(int i=0; i <= 10; i++)
            {
                await _connection.DeleteAsync(_listtodisplay[i]);
            }*/


            monthsList.ItemsSource = _listtodisplay;
            base.OnAppearing();
        }

        private async void monthsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var monthToDisplay = e.SelectedItem as Month;
            await Navigation.PushAsync(new MonthDetails(monthToDisplay));
            monthsList.SelectedItem = null;
        }
    }
}