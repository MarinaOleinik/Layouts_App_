using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts_App_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Frame_array : ContentPage
    {
        
        public Frame_array()
        {
            StackLayout st;
            Label lbl;
            int i;
            st = new StackLayout();
            Frame[] frames = new Frame[5];
            //Label kolmas = null;
            Label[] labels = new Label[5];
            
            for ( i = 0; i < 4; i++)
            {
                labels[i] = new Label();
                {

                }
                frames[i] = new Frame()
                {
                    BackgroundColor = Color.FromRgb(255 - i, 200 + i, 100 + i),
                    Content=labels[i]                   
                };
                st.Children.Add(frames[i]);
            };
            this.Content = st;
            
        }
    }
}