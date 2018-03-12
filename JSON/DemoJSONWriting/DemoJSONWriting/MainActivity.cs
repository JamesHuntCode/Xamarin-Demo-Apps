using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Newtonsoft.Json;

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

        public static List<Staff> staffMembers = new List<Staff>();

        // Method called when create button is clicked
        private void onCreate(object sender, System.EventArgs e)
        {

        }

        // Method ccalled when read button is clicked
        private void onRead(object sender, System.EventArgs e)
        {

        }

        // Method called when save button is clicked
        private void onSave(object sender, System.EventArgs e)
        {

        }
    }
}

