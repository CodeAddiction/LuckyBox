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
using Java.Lang;

namespace AssureGroup
{
    class BoxAdapter : BaseAdapter<Box>
    {

        List<Box> BoxList;

        public BoxAdapter(List<Box> Boxes)
        {
            this.BoxList = Boxes;
        }

        public override Box this[int position]
        {
            get
            {
                return BoxList[position];
            }
        }

        public override int Count
        {
            get
            {
                return BoxList.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.listItem, 
                    
                var boxImage = view.FindViewById<ImageButton>(Resource.Id.boxButton);
                var boxLabel = view.FindViewById<TextView>(Resource.Id.boxTitle);
                var boxPrice = view.FindViewById<TextView>(Resource.Id.boxPrice);

                view.Tag = new ViewHolder() { BoxImage = boxButton, boxLabel = boxLabel, boxPrice = boxPrice}
            }
                var holder = (ViewHolder)view.Tag;

                return View;
            }
        }
    }
}