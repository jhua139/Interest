using Android.App;
using Android.Widget;
using Android.OS;

namespace Interest
{
    [Activity(Label = "Interest", MainLauncher = true, Icon = "@drawable/discount")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

