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

namespace DemoJSONWriting
{
    [Activity(Label = "CreateStaff")]
    public class CreateStaff : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Spinner spinner = FindViewById<Spinner>(Resource.Id.spinnerRole);
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.role_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerItem);
            spinner.Adapter = adapter;
        }
    }
}