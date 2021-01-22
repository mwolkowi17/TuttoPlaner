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
    public partial class MonthDetailsPlanned : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        public ObservableCollection<Day> _listofdays;
        public string monthroboczy;

        public MonthDetailsPlanned(Month month)
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
            var listtodisplay = await _connection.Table<Day>().ToListAsync();
            _listofdays = new ObservableCollection<Day>(listtodisplay);
            var listOfDaysFiltred = _listofdays.Where(n => n.MonthofYear == monthroboczy)
                                               .Where(n => n.DayPlans!=null)
                                              .ToList();

            daysListPlanned.ItemsSource = listOfDaysFiltred;
            base.OnAppearing();

        }

        private async void daysList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var dayToDisplay = e.SelectedItem as Day;
            await Navigation.PushAsync(new DayDetails(dayToDisplay));
        }
    }
}