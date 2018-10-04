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
using Android.Support.Design.Widget;
using Android.Preferences;

namespace AssureGroup
{
    [Activity(Label = "BoxSelection")]
    public class BoxSelectionActivity : Activity
    {


        public ListView boxList;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.boxSelection);
            boxList = FindViewById<ListView>(Resource.Id.boxListView);

            List<Box> mItems = new List<Box>();
                mItems.Add(new Box(1, "Bronze","£1"));
                mItems.Add(new Box(2, "Silver", "£5"));
                mItems.Add(new Box(3, "Gold", "£10"));

            //ListView populating code
            BoxAdapter adapter = new BoxAdapter(this, mItems);
            boxList.Adapter = adapter;



        }
    }
}