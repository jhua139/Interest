using Android.App;
using Android.Widget;
using Android.OS;

namespace Interest
{
    [Activity(Label = "Interest", MainLauncher = true, Icon = "@drawable/discount")]
    public class MainActivity : Activity
    {
        TextView tvAsb, tvAnz, tvBnz, tvWestpac;
        ScrollView svAsb, svAnz, svBnz, svWestpac;

        Engine engine;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            tvAsb = (TextView)FindViewById(Resource.Id.textViewAsb);
            tvAnz = (TextView)FindViewById(Resource.Id.textViewAnz);
            tvBnz = (TextView)FindViewById(Resource.Id.textViewBnz);
            tvWestpac = (TextView)FindViewById(Resource.Id.textViewWestpac);

            svAsb = (ScrollView)FindViewById(Resource.Id.scrollViewAsb);
            svAnz = (ScrollView)FindViewById(Resource.Id.scrollViewAnz);
            svBnz = (ScrollView)FindViewById(Resource.Id.scrollViewBnz);
            svWestpac = (ScrollView)FindViewById(Resource.Id.scrollViewWestpac);

            tvAsb.Click += Asb_Click;

            engine = new Engine();
        }

        private void Asb_Click(object sender, System.EventArgs e)
        {
            engine.GetAnzData();
        }
    }
}

