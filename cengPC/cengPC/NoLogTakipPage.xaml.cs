using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cengPC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoLogTakipPage : ContentPage
    {
        public NoLogTakipPage()
        {
            InitializeComponent();
            Title = "Üyeliksiz Sipariş Takibi";
            BackgroundColor = Color.White;
            
           
        }
    }
}