using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections;
using System.IO;

namespace cengPC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class basketPage : ContentPage
    {
        public ArrayList urunlerDizisi = new ArrayList();

        public basketPage()
        {                InitializeComponent();

            /* 
             string[] straImageLocations = System.IO.Directory.GetFiles("DirectoryLocation", "*.png", SearchOption.TopDirectoryOnly);
            Image[] Deck = new Image[straImageLocations.Length];
            for (int i = 0; i < straImageLocations.Length; i++)
            {
                Deck[i] = Image.FromFile(straImageLocations[i]);
            }
            urunlerDizisi.Add("");
            if (urunlerDizisi.Count != 0)
            {
                String fotografIsmi = "";

                for (int i = 1; i < 6; i++)
                {
                    Image urunResmi = new Image();
                    Label urunIsmi = new Label();
                    fotografIsmi = "foto" + i;
                    urunResmi.Source = fotografIsmi;
                    urunResmi.Margin = new Thickness(10, 10, 10, 10);
                    urunIsmi.Text = "urun " + i;
                    urunIsmi.Margin = new Thickness(10, 10, 10, 10);
                    urunlerLayout.Children.Add(urunResmi);
                    urunlerLayout.Children.Add(urunIsmi);
                }
            }
            else
            {
                InitializeComponent();
            }*/
        }

       


        /*   public void LoadDynamicFields()
  {

  int count = 2;
      for(int i = 0; i < count; i++)
      {

      }
  }*/
    }
}