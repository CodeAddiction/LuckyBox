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
            public List<Box> mItems;
            public Context mContext;

            public BoxAdapter(Context context, List<Box> items)
            {
                mItems = items;
                mContext = context;
            }

            public override int Count
            {
                get
                {
                    return mItems.Count;
                }
            }

            public override Box this[int position]
            {
                get
                {
                    return mItems[position];
                }
            }

            public override long GetItemId(int position)
            {
                return position;
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                View row = convertView;

                if (row == null)
                {
                    row = LayoutInflater.From(mContext).Inflate(Resource.Layout.listItem, null, false);
                }

                ImageView boxIV = row.FindViewById<ImageView>(Resource.Id.boxButton);
            switch (boxIV.Id)
            {
                case 1:
                    boxIV.SetImageResource(Resource.Drawable.bronzeBox);
                    break;
                case 2:
                    boxIV.SetImageResource(Resource.Drawable.silverBox);
                    break;
                case 3:
                    boxIV.SetImageResource(Resource.Drawable.goldBox);
                    break;
            }
            boxIV.SetImageResource(Resource.Drawable.bronzeBox);

                TextView boxTitleTV = row.FindViewById<TextView>(Resource.Id.boxTitle);
                boxTitleTV.Text = mItems[position].BoxLabel;

            TextView boxPriceTV = row.FindViewById<TextView>(Resource.Id.boxPrice);
            boxTitleTV.Text = mItems[position].BoxPrice;

            return row;
            }



        }


    }