using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts_App_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        Label punane, kollane, roheline;
        Frame pun, kol, roh;
        Button sisse, valja;
        bool sisse_valja;
        public Valgusfoor2()
        {
            //InitializeComponent();
            sisse_valja = false;
            punane = new Label()
            {
                Text = "Punane",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            pun = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = punane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };

            Label kollane = new Label()
            {
                Text = "Kollane",
                TextColor = Color.Yellow,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Label roheline = new Label()
            {
                Text = "Roheline",
                TextColor = Color.Green,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold

            };
            sisse = new Button()
            {
                Text = "Sisse",
                BackgroundColor = Color.FromRgb(200, 100, 45),
                BorderColor = Color.FromRgb(50, 150, 200)

            };
            valja = new Button()
            {
                Text = "Välja",
                BackgroundColor = Color.FromRgb(200, 100, 45),
                BorderColor = Color.FromRgb(50, 150, 200)
                
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { pun,  kollane, roheline, sisse, valja }

            };
            sisse.Clicked += Sisse_Clicked;
            valja.Clicked += Valja_Clicked;
            Content = stackLayout;
            
            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            pun.GestureRecognizers.Add(tap);
        }

        private void Valja_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.Gray;
            sisse_valja = true;
        }
        private async void Sisse_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.Red;
            pun.BorderColor = Color.WhiteSmoke;
            sisse_valja = false;
            for (int i = 0; i < 100; i++)
            {
                punane.FontSize++;
                await Task.Run(() => Thread.Sleep(1000));//пауза в 1 сек
            }         
        }
        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr=sender as Frame;
            if (fr == pun) { punane.Text = "Seisa ja oota!!!"; }
            
        }
    }
}