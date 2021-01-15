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
    public partial class DayUpdate : ContentPage
    {
        public SQLiteAsyncConnection _connection;
        public DayUpdate(Day day)
        {
            if (day == null)
                throw new ArgumentNullException();
            BindingContext = day;
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           var dayplans = sender as Button;
            var dayToUpdate = dayplans.CommandParameter as Day;
            dayToUpdate.DayPlans = NoteBody.Text;
            await _connection.UpdateAsync(dayToUpdate);
            await Navigation.PopAsync();


        }
    }
}