using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Runtime;
using System;

namespace smartmarktAndroid
{
    [Activity(Label = "smartmarktAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        
        protected override void OnCreate(Bundle bundle)
        {
           
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button readButton = FindViewById<Button>(Resource.Id.readButton);
            readButton.Click += (object sender, EventArgs e) =>
            {
                // Translate user's alphanumeric phone number to numeric
                Console.WriteLine("Pushed!!");
            };
        }

    }
}

