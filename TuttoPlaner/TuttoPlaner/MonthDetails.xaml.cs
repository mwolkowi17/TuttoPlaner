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
    public partial class MonthDetails : ContentPage
    {
        public MonthDetails(Month month)
        {
            if (month == null)
                throw new ArgumentNullException();
            BindingContext = month;
            InitializeComponent();
        }
    }
}