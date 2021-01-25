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
        public DateTime dateRobocza;
        public int mothnumber;
        public int daynumber;

        public MonthDetails(Month month)
        {
            if (month == null)
                throw new ArgumentNullException();
            BindingContext = month;
            monthroboczy = month.MonthName;
            mothnumber = month.MonthId;
            daynumber = 1;
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

            dateRobocza = new DateTime(2021, mothnumber, daynumber);
        }

        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<Day>();
            var day1 = new Day() { DayNumber = "1", MonthofYear=monthroboczy , DayToDisplay=dateRobocza.Date.DayOfWeek.ToString()};
            daynumber = 2;
            var dateRobocza2 = new DateTime(2021, mothnumber, daynumber);
            var day2 = new Day() { DayNumber = "2", MonthofYear = monthroboczy, DayToDisplay = dateRobocza2.Date.DayOfWeek.ToString() };
            daynumber = 3;
            var dateRobocza3 = new DateTime(2021, mothnumber, daynumber);
           // dateRobocza = new DateTime(2021, mothnumber, daynumber);
            var day3 = new Day() { DayNumber = "3", MonthofYear = monthroboczy, DayToDisplay = dateRobocza3.Date.DayOfWeek.ToString() };
            daynumber = 4;
            var dateRobocza4 = new DateTime(2021, mothnumber, daynumber);
            var day4 = new Day() { DayNumber = "4", MonthofYear = monthroboczy, DayToDisplay = dateRobocza4.Date.DayOfWeek.ToString() };
            daynumber = 5;
            var dateRobocza5 = new DateTime(2021, mothnumber, daynumber);
            var day5 = new Day() { DayNumber = "5", MonthofYear = monthroboczy, DayToDisplay = dateRobocza5.Date.DayOfWeek.ToString() };
            daynumber = 6;
            var dateRobocza6 = new DateTime(2021, mothnumber, daynumber);
            var day6 = new Day() { DayNumber = "6", MonthofYear = monthroboczy, DayToDisplay = dateRobocza6.Date.DayOfWeek.ToString() };
            daynumber = 7;
            var dateRobocza7 = new DateTime(2021, mothnumber, daynumber);
            var day7 = new Day() { DayNumber = "7", MonthofYear = monthroboczy, DayToDisplay = dateRobocza7.Date.DayOfWeek.ToString() };
            daynumber = 8;
            var dateRobocza8 = new DateTime(2021, mothnumber, daynumber);
            var day8 = new Day() { DayNumber = "8", MonthofYear = monthroboczy, DayToDisplay = dateRobocza8.Date.DayOfWeek.ToString() };
            daynumber = 9;
            var dateRobocza9 = new DateTime(2021, mothnumber, daynumber);
            var day9 = new Day() { DayNumber = "9", MonthofYear = monthroboczy, DayToDisplay = dateRobocza9.Date.DayOfWeek.ToString() };
            daynumber = 10;
            var dateRobocza10 = new DateTime(2021, mothnumber, daynumber);
            var day10 = new Day() { DayNumber = "10", MonthofYear = monthroboczy, DayToDisplay = dateRobocza10.Date.DayOfWeek.ToString() };
            daynumber = 11;
            var dateRobocza11 = new DateTime(2021, mothnumber, daynumber);
            var day11 = new Day() { DayNumber = "11", MonthofYear = monthroboczy, DayToDisplay = dateRobocza11.Date.DayOfWeek.ToString() };
            daynumber = 12;
            var dateRobocza12 = new DateTime(2021, mothnumber, daynumber);
            var day12 = new Day() { DayNumber = "12", MonthofYear = monthroboczy, DayToDisplay = dateRobocza12.Date.DayOfWeek.ToString() };
            daynumber = 13;
            var dateRobocza13 = new DateTime(2021, mothnumber, daynumber);
            var day13 = new Day() { DayNumber = "13", MonthofYear = monthroboczy, DayToDisplay = dateRobocza13.Date.DayOfWeek.ToString() };
            daynumber = 14;
            var dateRobocza14 = new DateTime(2021, mothnumber, daynumber);
            var day14 = new Day() { DayNumber = "14", MonthofYear = monthroboczy, DayToDisplay = dateRobocza14.Date.DayOfWeek.ToString() };
            daynumber = 15;
            var dateRobocza15 = new DateTime(2021, mothnumber, daynumber);
            var day15 = new Day() { DayNumber = "15", MonthofYear = monthroboczy, DayToDisplay = dateRobocza15.Date.DayOfWeek.ToString() };
            daynumber = 16;
            var dateRobocza16 = new DateTime(2021, mothnumber, daynumber);
            var day16 = new Day() { DayNumber = "16", MonthofYear = monthroboczy, DayToDisplay = dateRobocza16.Date.DayOfWeek.ToString() };
            daynumber = 17;
            var dateRobocza17 = new DateTime(2021, mothnumber, daynumber);
            var day17 = new Day() { DayNumber = "17", MonthofYear = monthroboczy, DayToDisplay = dateRobocza17.Date.DayOfWeek.ToString() };
            daynumber = 18;
            var dateRobocza18 = new DateTime(2021, mothnumber, daynumber);
            var day18 = new Day() { DayNumber = "18", MonthofYear = monthroboczy, DayToDisplay = dateRobocza18.Date.DayOfWeek.ToString() };
            daynumber = 19;
            var dateRobocza19 = new DateTime(2021, mothnumber, daynumber);
            var day19 = new Day() { DayNumber = "19", MonthofYear = monthroboczy, DayToDisplay = dateRobocza19.Date.DayOfWeek.ToString() };
            daynumber = 20;
            var dateRobocza20 = new DateTime(2021, mothnumber, daynumber);
            var day20 = new Day() { DayNumber = "20", MonthofYear = monthroboczy, DayToDisplay = dateRobocza20.Date.DayOfWeek.ToString() };
            daynumber = 21;
            var dateRobocza21 = new DateTime(2021, mothnumber, daynumber);
            var day21 = new Day() { DayNumber = "21", MonthofYear = monthroboczy, DayToDisplay = dateRobocza21.Date.DayOfWeek.ToString() };
            daynumber = 22;
            var dateRobocza22 = new DateTime(2021, mothnumber, daynumber);
            var day22 = new Day() { DayNumber = "22", MonthofYear = monthroboczy, DayToDisplay = dateRobocza22.Date.DayOfWeek.ToString() };
            daynumber = 23;
            var dateRobocza23 = new DateTime(2021, mothnumber, daynumber);
            var day23 = new Day() { DayNumber = "23", MonthofYear = monthroboczy, DayToDisplay = dateRobocza23.Date.DayOfWeek.ToString() };
            daynumber = 24;
            var dateRobocza24 = new DateTime(2021, mothnumber, daynumber);
            var day24 = new Day() { DayNumber = "24", MonthofYear = monthroboczy, DayToDisplay = dateRobocza24.Date.DayOfWeek.ToString() };
            daynumber = 25;
            var dateRobocza25 = new DateTime(2021, mothnumber, daynumber);
            var day25 = new Day() { DayNumber = "25", MonthofYear = monthroboczy, DayToDisplay = dateRobocza25.Date.DayOfWeek.ToString() };
            daynumber = 26;
            var dateRobocza26 = new DateTime(2021, mothnumber, daynumber);
            var day26 = new Day() { DayNumber = "26", MonthofYear = monthroboczy, DayToDisplay = dateRobocza26.Date.DayOfWeek.ToString() };
            daynumber = 27;
            var dateRobocza27 = new DateTime(2021, mothnumber, daynumber);
            var day27 = new Day() { DayNumber = "27", MonthofYear = monthroboczy, DayToDisplay = dateRobocza27.Date.DayOfWeek.ToString() };
            daynumber = 28;
            var dateRobocza28 = new DateTime(2021, mothnumber, daynumber);
            var day28 = new Day() { DayNumber = "28", MonthofYear = monthroboczy, DayToDisplay = dateRobocza28.Date.DayOfWeek.ToString() };

            // tu trzeba dać jakieś ograniczenie dla lutego 28 dni i mieśiecy które mają 30 dni 
          
            List<Day> robocza2 = await _connection.Table<Day>().Where(n=>n.MonthofYear==monthroboczy)
                                                               .ToListAsync();
            if (robocza2.Count() == 0)
            {
               await _connection.InsertAsync(day1);
               await _connection.InsertAsync(day2);
               await _connection.InsertAsync(day3);
                await _connection.InsertAsync(day4);
                await _connection.InsertAsync(day5);
                await _connection.InsertAsync(day6);
                await _connection.InsertAsync(day7);
                await _connection.InsertAsync(day8);
                await _connection.InsertAsync(day9);
                await _connection.InsertAsync(day10);
                await _connection.InsertAsync(day11);
                await _connection.InsertAsync(day12);
                await _connection.InsertAsync(day13);
                await _connection.InsertAsync(day14);
                await _connection.InsertAsync(day15);
                await _connection.InsertAsync(day16);
                await _connection.InsertAsync(day17);
                await _connection.InsertAsync(day18);
                await _connection.InsertAsync(day19);
                await _connection.InsertAsync(day20);
                
                await _connection.InsertAsync(day21);
                await _connection.InsertAsync(day22);
                await _connection.InsertAsync(day23);
                await _connection.InsertAsync(day24);
                await _connection.InsertAsync(day25);
                await _connection.InsertAsync(day26);
                await _connection.InsertAsync(day27);
                await _connection.InsertAsync(day28);
               
               
            }
            if (mothnumber == 1 || mothnumber == 3 || mothnumber == 5 || mothnumber == 7 || mothnumber == 8 || mothnumber == 10 || mothnumber == 12)
            {


                daynumber = 29;
                var dateRobocza29 = new DateTime(2021, mothnumber, daynumber);
                var day29 = new Day() { DayNumber = "29", MonthofYear = monthroboczy, DayToDisplay = dateRobocza29.Date.DayOfWeek.ToString() };
                daynumber = 30;
                var dateRobocza30 = new DateTime(2021, mothnumber, daynumber);
                var day30 = new Day() { DayNumber = "30", MonthofYear = monthroboczy, DayToDisplay = dateRobocza30.Date.DayOfWeek.ToString() };
                daynumber = 31;
                var dateRobocza31 = new DateTime(2021, mothnumber, daynumber);
                var day31 = new Day() { DayNumber = "31", MonthofYear = monthroboczy, DayToDisplay = dateRobocza31.Date.DayOfWeek.ToString() };
                if (monthroboczy != "February")
                {
                    await _connection.InsertAsync(day29);
                    await _connection.InsertAsync(day30);
                }
                if (robocza2.Count() == 30 && (monthroboczy == "January" || monthroboczy == "March" || monthroboczy == "May" || monthroboczy == "July" || monthroboczy == "August" || monthroboczy == "October" || monthroboczy == "December"))
                {
                    await _connection.InsertAsync(day31);
                }
            }

          
           
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

        private async void daysList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var dayToDisplay = e.SelectedItem as Day;
            await Navigation.PushAsync(new DayDetails(dayToDisplay));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Month monthData = await _connection.Table<Month>()
                                               .Where(n=>n.MonthName==monthroboczy)
                                               
                                               .FirstAsync();
            
                            
            await Navigation.PushAsync(new MonthDetailsPlanned(monthData));
        }
    }
}