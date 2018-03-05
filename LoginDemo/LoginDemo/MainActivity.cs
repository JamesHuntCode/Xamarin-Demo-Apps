using Android.App;
using Android.Widget;
using Android.OS;

namespace LoginDemo
{
    [Activity(Label = "LoginDemo", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        // Create admin account
        User admin = new User { Email = "admin@admin", Username = "admin", Password = "letmein" };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Create button click event for login
            var loginButton = FindViewById<Button>(Resource.Id.btnLogin);
            loginButton.Click += OnLogin;

            // Create button click event for registration
            var registrationButton = FindViewById<Button>(Resource.Id.btnRegister);
            registrationButton.Click += delegate { StartActivity(typeof(registration)); };
        }

        private void OnLogin(object sender, System.EventArgs e)
        {
            EditText email, password;
            email = FindViewById<EditText>(Resource.Id.etEmail);
            password = FindViewById<EditText>(Resource.Id.etPassword);

            TextView status;
            status = FindViewById<TextView>(Resource.Id.tvStatus);

            // Check login details
            if (!string.IsNullOrEmpty(email.Text) && (email.Text == admin.Email) && (password.Text == admin.Password))
            {
                status.Text = "Welcome admin!";
                admin.Authenticated = true;
            } 
            else
            {
                status.Text = "Oops! Check your login details and retry";
            }
        }
    }
}

