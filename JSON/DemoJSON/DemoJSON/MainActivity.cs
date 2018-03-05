using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.Res;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DemoJSON
{
    [Activity(Label = "DemoJSON", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        public static List<Models.Staff_Member> admin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Populate view from JSON file
            LoadJSON();

            ListView lv = FindViewById<ListView>(Resource.Id.listUser);

            lv.Adapter = new UserAdapter(this, admin);
        }

        // Method to read contents of a JSON file
        private void LoadJSON()
        {
            AssetManager assets = this.Assets;

            using (StreamReader mySR = new StreamReader(assets.Open("data.json")))
            {
                string content = mySR.ReadToEnd();
                admin = JsonConvert.DeserializeObject<List<Models.Staff_Member>>(content);
            }
        }
    }
}

