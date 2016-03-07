using Xamarin.Forms.Platform.Android;
using Org.Xwalk.Core;
using Xamarin.Forms;
using XWalkViewFormsApp;
using XWalkViewFormsApp.Droid;

#if __XWALK__
[assembly: ExportCell(typeof(WebViewEx), typeof(WebViewExRendererXWalkView))]
#endif

namespace XWalkViewFormsApp.Droid
{
    public class WebViewExRendererXWalkView : ViewRenderer<WebViewEx, XWalkView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebViewEx> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                var xWalkView = new XWalkView(Context);
                SetNativeControl(xWalkView);

                xWalkView.Load(Element.Url, null);
            }
        }
    }
}