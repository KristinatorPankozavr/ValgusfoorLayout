using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Valgusfoor_1
{
    public partial class MainPage : ContentPage
    {
        bool vkl;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void on_Clicked(object sender, EventArgs e)
        {
            vkl = true;
            while (vkl!=false)
            {
                punane.BackgroundColor = Color.Red;
                kollane.BackgroundColor = Color.Gray;
                roheline.BackgroundColor = Color.Gray;
                await Task.Run(() => Thread.Sleep(1000));
                {
                    kollane.BackgroundColor = Color.Yellow;
                    punane.BackgroundColor = Color.Gray;
                    roheline.BackgroundColor = Color.Gray;
                    await Task.Run(() => Thread.Sleep(1000));
                }
                roheline.BackgroundColor = Color.Green;
                punane.BackgroundColor = Color.Gray;
                kollane.BackgroundColor = Color.Gray;
                await Task.Run(() => Thread.Sleep(1000));
                
            }

    }

        private void off_Clicked(object sender, EventArgs e)
        {
            punane.BackgroundColor = Color.Gray;
            kollane.BackgroundColor = Color.Gray;
            roheline.BackgroundColor = Color.Gray;
            vkl = false;
        }
        Random rnd = new Random();
        private void Random_Clicked(object sender, EventArgs e)
        {
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            punane.BackgroundColor = Color.FromRgb(r, g, b);
             r = rnd.Next(0, 255);
             g = rnd.Next(0, 255);
             b = rnd.Next(0, 255);
            kollane.BackgroundColor = Color.FromRgb(r, g, b);
             r = rnd.Next(0, 255);
             g = rnd.Next(0, 255);
             b = rnd.Next(0, 255);
            roheline.BackgroundColor = Color.FromRgb(r, g, b);
        }

        private void Oma_Clicked(object sender, EventArgs e)       
        {
            punane.Opacity = 0.5;
            kollane.CornerRadius = 0;
            roheline.CornerRadius = 2;

        }
    }
}
