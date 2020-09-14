using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts_App_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor : ContentPage
    {
        bool vkl;
        public Valgusfoor()
        {
            InitializeComponent();
        }
        
        private async void on_Clicked(object sender, EventArgs e)
        {
            vkl = true;
            while (vkl!=false)
            {
                pun.BackgroundColor = Color.Red;
                kol.BackgroundColor = Color.Gray;
                roh.BackgroundColor = Color.Gray;
                await Task.Run(() => Thread.Sleep(3000));
                for (int i = 0; i < 3; i++)
                {
                    pun.BackgroundColor = Color.Gray;
                    pun.BackgroundColor = Color.Gray;
                    roh.BackgroundColor = Color.Gray;
                    await Task.Run(() => Thread.Sleep(500));
                    kol.BackgroundColor = Color.Yellow;  
                }               
                roh.BackgroundColor = Color.Green;
                pun.BackgroundColor = Color.Gray;
                kol.BackgroundColor = Color.Gray;
                await Task.Run(() => Thread.Sleep(3000));                
            }          
        }
        private void off_Clicked(object sender, EventArgs e)
        {           
            pun.BackgroundColor = Color.Gray;
            kol.BackgroundColor = Color.Gray;
            roh.BackgroundColor = Color.Gray;
            vkl = false;  
        }
        Random rnd = new Random();
        private void Random_Clicked(object sender, EventArgs e)
        {
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            pun.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            kol.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            roh.BackgroundColor = Color.FromRgb(r, g, b);
        }

        private async void Oma_Clicked(object sender, EventArgs e)
        {
            pun.Opacity = 0.5;
            kol.CornerRadius = 0;
            roheline.Text = "Minu oma ...";
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);                
            roh.BorderColor = Color.FromRgb(r, g, b);
            roh.HasShadow = true;
            bool vastus = await DisplayAlert("Värvi muutus", 
                "Kas tahad värvi muuta? UUe värvi värtused red:"
                +r.ToString()+" green:"+g.ToString()+" blue:"+b.ToString(), 
                "Jah", "Ei");
            if (vastus)

            {
                Fon.BackgroundColor = Color.FromRgb(r, g, b);
            }
            else
            {
                Fon.BackgroundColor = Color.FromRgb(0, 0, 0);
            }
        }
    }
}