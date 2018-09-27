using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Threading;
using Android.Content;

namespace AssureGroup
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true,NoHistory =true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.splash);

            Thread.Sleep(6000);
            Intent loginIntent = new Intent(this, typeof(LoginActivity));
            StartActivity(loginIntent);
        }
    }
}