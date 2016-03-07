using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XWalkViewFormsApp;
using XWalkViewFormsApp.Droid;

#if !(__XWALK__)
[assembly: ExportCell(typeof(WebViewEx), typeof(WebViewExRenderer))]
#endif

namespace XWalkViewFormsApp.Droid
{
    public class WebViewExRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.LoadUrl(((WebViewEx)Element).Url);
            }
        }
    }
}