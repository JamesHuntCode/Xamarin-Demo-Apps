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
    public class Member : User
    {
        string Address { get; set; }
        string MemberShipNumber { get; set; }

        // Method to allow members to reserve books
        public void ReserveItem()
        {

        }
    }
}