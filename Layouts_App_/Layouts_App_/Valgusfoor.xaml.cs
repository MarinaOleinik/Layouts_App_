using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts_App_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor : ContentPage
    {
        public Valgusfoor()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        
        private void on_Clicked(object sender, EventArgs e)
        {
            int c=rnd.Next(1, 4);
            if (c==1)
            {
                pun.BackgroundColor = Color.FromRgb(255, 0, 0);
                kol.BackgroundColor = Color.Gray;
                roh.BackgroundColor = Color.Gray;
            }
            else if(c==2)
            {

            }
            else
            {

            }
        }

        private void off_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.FromRgb(100, 100, 100);
            kol.BackgroundColor = Color.Gray;
            roh.BackgroundColor = Color.FromHex("#aaaaaa");


        }
    }
}