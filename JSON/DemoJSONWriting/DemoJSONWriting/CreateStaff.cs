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

        private void onCreateNewUser(Object sender, System.EventArgs e)
        {
            Staff staff = new Staff();

            staff.FirstName = FindViewById<EditText>(Resource.Id.etFirstName).Text;
            staff.LastName = FindViewById<EditText>(Resource.Id.etFirstName).Text;
            staff.Email = FindViewById<EditText>(Resource.Id.etEmail).Text;
            staff.Password = FindViewById<EditText>(Resource.Id.etPassword).Text;

            staff.Role = new Role { Description = FindViewById<Spinner>(Resource.Id.spinnerRole).SelectedItem.ToString() };

            MainActivity.staffMembers.Add(staff);

            Finish();
        }
    }
}