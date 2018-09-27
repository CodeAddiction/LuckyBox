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

namespace AssureGroup
{
    [Activity(Label = "BoxSelection")]
    public class BoxSelection : Activity
    {

        private ListView boxList;
        private Adapter mAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);



            boxList = FindViewById<ListView>(Resource.Id.boxListView);
            mAdapter = new Adapter(this, typeof(Resource.Id.boxList));
            listView.Adapter = new HomeScreenAdapter(this, tableItems);
            listView.ItemClick += OnListItemClick;  // to be defined
        }
    }
}