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

namespace LoginDemo
{
    [Activity(Label = "registration")]
    public class registration : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.registration);

            // Set on click event for register button
            var regButton = FindViewById<Button>(Resource.Id.btnRegister);
            regButton.Click += OnRegister;
        }


        private void OnRegister(object sender, System.EventArgs e)
        {
            EditText username, email, password;
            email = FindViewById<EditText>(Resource.Id.etEmail);
            username = FindViewById<EditText>(Resource.Id.etUsername);
            password = FindViewById<EditText>(Resource.Id.etPassword);

            TextView status;
            status = FindViewById<TextView>(Resource.Id.tvStatus);

            // Check login details
            if (!string.IsNullOrEmpty(username.Text) && !String.IsNullOrEmpty(email.Text) && !String.IsNullOrEmpty(password.Text))
            {
                // Create login details
                string newUsername, newPassword, newEmail;
                newUsername = username.Text;
                newEmail = email.Text;
                newPassword = password.Text;

                User newUser = new User { Email = newEmail, Username = newUsername, Password = newPassword };

                status.Text = "Welcome " + newUser.Username + "!";
            }
            else
            {
                status.Text = "Oops! Please enter your full details.";
            }
        }
    }
}