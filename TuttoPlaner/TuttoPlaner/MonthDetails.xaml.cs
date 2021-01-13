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
            var day4 = new Day() { DayNumber = "4", MonthofYear = monthroboczy };
            var day5 = new Day() { DayNumber = "5", MonthofYear = monthroboczy };
            var day6 = new Day() { DayNumber = "6", MonthofYear = monthroboczy };
            var day7 = new Day() { DayNumber = "7", MonthofYear = monthroboczy };
            var day8 = new Day() { DayNumber = "8", MonthofYear = monthroboczy };
            var day9 = new Day() { DayNumber = "9", MonthofYear = monthroboczy };
            var day10 = new Day() { DayNumber = "10", MonthofYear = monthroboczy };
            var day11 = new Day() { DayNumber = "11", MonthofYear = monthroboczy };
            var day12 = new Day() { DayNumber = "12", MonthofYear = monthroboczy };
            var day13 = new Day() { DayNumber = "13", MonthofYear = monthroboczy };
            var day14 = new Day() { DayNumber = "14", MonthofYear = monthroboczy };
            var day15 = new Day() { DayNumber = "15", MonthofYear = monthroboczy };
            var day16 = new Day() { DayNumber = "16", MonthofYear = monthroboczy };
            var day17 = new Day() { DayNumber = "17", MonthofYear = monthroboczy };
            var day18 = new Day() { DayNumber = "18", MonthofYear = monthroboczy };
            var day19 = new Day() { DayNumber = "19", MonthofYear = monthroboczy };
            var day20 = new Day() { DayNumber = "20", MonthofYear = monthroboczy };
            var day21 = new Day() { DayNumber = "21", MonthofYear = monthroboczy };
            var day22 = new Day() { DayNumber = "22", MonthofYear = monthroboczy };
            var day23 = new Day() { DayNumber = "23", MonthofYear = monthroboczy };
            var day24 = new Day() { DayNumber = "24", MonthofYear = monthroboczy };
            var day25 = new Day() { DayNumber = "25", MonthofYear = monthroboczy };
            var day26 = new Day() { DayNumber = "26", MonthofYear = monthroboczy };
            var day27 = new Day() { DayNumber = "27", MonthofYear = monthroboczy };
            var day28 = new Day() { DayNumber = "28", MonthofYear = monthroboczy };
            var day29 = new Day() { DayNumber = "29", MonthofYear = monthroboczy };
            var day30 = new Day() { DayNumber = "30", MonthofYear = monthroboczy };
            var day31 = new Day() { DayNumber = "31", MonthofYear = monthroboczy };

            List<Day> robocza2 = await _connection.Table<Day>().Where(n=>n.MonthofYear==monthroboczy)
                                                               .ToListAsync();
            /*if (robocza2.Count() == 0)
            {
               await _connection.InsertAsync(day1);
               await _connection.InsertAsync(day2);
               await _connection.InsertAsync(day3);
            }*/
           
            var listtodisplay = await _connection.Table<Day>().ToListAsync();
            _listofdays = new ObservableCollection<Day>(listtodisplay);

            /*for (int i = 0; i <= 2; i++)
            {
                await _connection.DeleteAsync(_listofdays[i]);
            }*/

            var listOfDaysFiltred = _listofdays.Where(n => n.MonthofYear == monthroboczy)
                                               .ToList();
           
            daysList.ItemsSource = listOfDaysFiltred;
            base.OnAppearing();
        }
    }
}