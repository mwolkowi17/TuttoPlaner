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
    public partial class MonthDetails : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        public ObservableCollection<Day> _listofdays;
        public string monthroboczy;

        public MonthDetails(Month month)
        {
            if (month == null)
                throw new ArgumentNullException();
            BindingContext = month;
            monthroboczy = month.MonthName;


            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

        }

        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<Day>();
            var day1 = new Day() { DayNumber = "1", MonthofYear=monthroboczy };
            var day2 = new Day() { DayNumber = "2", MonthofYear = monthroboczy };
            var day3 = new Day() { DayNumber = "3", MonthofYear = monthroboczy };
            List<Day> robocza2 = await _connection.Table<Day>().Where(n=>n.MonthofYear==monthroboczy)
                                                               .ToListAsync();
            if (robocza2.Count() == 0)
            {
               await _connection.InsertAsync(day1);
               await _connection.InsertAsync(day2);
               await _connection.InsertAsync(day3);
            }
            var listtodisplay = await _connection.Table<Day>().ToListAsync();
            _listofdays = new ObservableCollection<Day>(listtodisplay);
            var listOfDaysFiltred = _listofdays.Where(n => n.MonthofYear == monthroboczy)
                                               .ToList();
            // displaying list should be connected with monath names, (add linq filter)
            daysList.ItemsSource = listOfDaysFiltred;
            base.OnAppearing();
        }
    }
}