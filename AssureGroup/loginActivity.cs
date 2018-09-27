using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AssureGroup
{
    [Activity(Label = "loginActivity")]
    public class LoginActivity : Activity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login);

            Button loginBtn = FindViewById<Button>(Resource.Id.loginBtn);
            Button registerBtn = FindViewById<Button>(Resource.Id.registerBtn);


            loginBtn.Click += delegate {
                Intent startLogin = new Intent(this, typeof(BoxSelection));
                StartActivity(startLogin);
            };

            registerBtn.Click += delegate {
                Intent register = new Intent(this, typeof(Register));
                StartActivity(register);
            };
        }
}
}