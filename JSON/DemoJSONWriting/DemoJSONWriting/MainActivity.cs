﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace DemoJSONWriting
{
    [Activity(Label = "DemoJSONWriting", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Button widgets
            Button create = FindViewById<Button>(Resource.Id.btnCreate);
            Button read = FindViewById<Button>(Resource.Id.btnRead);
            Button save = FindViewById<Button>(Resource.Id.btnSaveData);

            // Button on click events
            create.Click += this.onCreate;
            read.Click += this.onRead;
            save.Click += this.onSave;
        }

        private void onCreate(object sender, System.EventArgs e)
        {

        }

        private void onRead(object sender, System.EventArgs e)
        {

        }

        private void onSave(object sender, System.EventArgs e)
        {

        }
    }
}
