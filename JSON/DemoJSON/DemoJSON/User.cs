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

namespace DemoJSON
{
    public class User
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
}