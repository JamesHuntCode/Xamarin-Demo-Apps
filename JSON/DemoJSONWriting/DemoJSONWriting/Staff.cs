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
    public class Staff : User
    {
        public Role Role { get; set; }
        public bool Volunteer { get; set; }

        public Staff()
        {

        }
    }
}