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
    public class UserAdapter : BaseAdapter<Models.Staff_Member>
    {
        private Activity _context;
        private List<Models.Staff_Member> _staff;

        public UserAdapter(Activity context, List<Models.Staff_Member> staff) : base()
        {
            _context = context;
            _staff = staff;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Models.Staff_Member this[int position]
        {
            get { return _staff[position]; }
        }

        public override int Count
        {
            get { return _staff.Count; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = _context.LayoutInflater.Inflate(Resource.Layout.UserViewItem, null);
                view.FindViewById<TextView>(Resource.Id.textItem).Text = _staff[position].Username;
            }

            return view;
        }
    }
}