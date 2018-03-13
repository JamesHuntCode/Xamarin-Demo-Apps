﻿using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

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
            create.Click += onCreate;
            read.Click += onRead;
            save.Click += onSave;
        }

        public static List<Staff> staffMembers = new List<Staff>();

        // Method called when create button is clicked
        public static void onCreate(object sender, System.EventArgs e)
        {

        }

        // Method ccalled when read button is clicked
        public static void onRead(object sender, System.EventArgs e)
        {

        }

        // Method called when save button is clicked
        public static void onSave(object sender, System.EventArgs e)
        {
            // Check array entries before proceeding 
            if ((staffMembers.Count > 0) && (staffMembers != null))
            {
                // safe to proceed

                string filePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                string fileName = Path.Combine(filePath, "staff.json");

                string serialiseStaff = JsonConvert.SerializeObject(staffMembers);

                using (StreamWriter mySR = new StreamWriter(fileName, false))
                {
                    mySR.Write(serialiseStaff);
                }
            }
        }
    }
}

