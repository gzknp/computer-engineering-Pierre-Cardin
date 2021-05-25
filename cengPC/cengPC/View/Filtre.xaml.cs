using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using cengPC.Model;

namespace cengPC.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Filtre : ContentPage
    {
        public Filtre()
        {
            InitializeComponent();        

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
        public void OnPickerSelectedIndexChanged (object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            var selectedItem = picker.SelectedItem;
            Console.WriteLine(selectedItem);
        }
    }
}