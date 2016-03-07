using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XWalkViewFormsApp
{
    public class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new WebViewEx
                    {
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Url = "https://www.google.com"
                    }
                }
            };
        }
    }
}
