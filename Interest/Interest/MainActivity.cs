using Android.App;
using Android.Widget;
using Android.OS;

namespace Interest
{
    [Activity(Label = "Interest", MainLauncher = true, Icon = "@drawable/discount")]
    public class MainActivity : Activity
    {
        TextView tvAsb, tvAnz, tvBnz, tvWestpac;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            tvAsb = (TextView) FindViewById(Resource.Id.textViewAsb);
            tvAnz = (TextView)FindViewById(Resource.Id.textViewAnz);
            tvBnz = (TextView)FindViewById(Resource.Id.textViewBnz);
            tvWestpac = (TextView)FindViewById(Resource.Id.textViewWestpac);
        }
        
    }
}

