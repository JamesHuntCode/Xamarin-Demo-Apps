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
using System.IO;
using Newtonsoft.Json;

namespace DemoJSONWriting
{
    [Activity(Label = "DisplayStaff")]
    public class DisplayStaff : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            this.loadJSON();
        }

        private List<Staff> staff = new List<Staff>();

        private void loadJSON()
        {
            string filePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string fileName = Path.Combine(filePath, "staff.json");

            using (StreamReader mySR = new StreamReader(fileName))
            {
                string content = mySR.ReadToEnd();

                staff = JsonConvert.DeserializeObject<List<Staff>>(content);
            }
        }
    }
}