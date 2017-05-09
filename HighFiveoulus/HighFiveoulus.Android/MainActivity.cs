using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Android.OS;

namespace HighFiveoulus.Droid
{
    [Activity(Label = "HighFiveoulus", Icon = "@drawable/fiveoulus", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    [assembly: ExportRenderer(typeof(Button), typeof(FSL.XF1.Droid.FlatButtonRenderer))]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
        public class FlatButtonRenderer : ButtonRenderer
        {
            protected override void OnDraw(Android.Graphics.Canvas canvas)
            {
                base.OnDraw(canvas);
            }

            protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
            {
                base.OnElementChanged(e);
            }
        }
    }
}

