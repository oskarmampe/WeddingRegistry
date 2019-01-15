using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace WeddingRegistry
{
    [Activity(Label = "@string/app_name", MainLauncher = true, Theme = "@style/AppTheme.NoActionBar")]
    public class LoginActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_login);

            FindViewById<TextView>(Resource.Id.app_bar_tv_title).Text = "Login";

            Button button = FindViewById<Button>(Resource.Id.login_btn_submit);
            button.Click += Login;
        }

        private void Login(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Clicked", ToastLength.Short).Show();
        }
    }
}