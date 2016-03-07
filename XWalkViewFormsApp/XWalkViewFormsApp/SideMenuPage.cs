using System;
using System.Collections.Generic;
using System.Text;
using Android.Widget;
using Xamarin.Forms;

namespace XWalkViewFormsApp
{
    public class SideMenuPage : ContentPage
    {
        public SideMenuPage()
        {
            Title = "Side menu";
            Content = new Label {Text = "Test123", BackgroundColor = Color.Black, };
        }
    }
}
