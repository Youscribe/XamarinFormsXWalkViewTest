using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XWalkViewFormsApp
{
    public class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            Master = new SideMenuPage();
            Detail = new NavigationPage(new WebViewPage());
        }
    }
}
