﻿using System;
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


        ListView boxList;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            boxList = FindViewById<ListView>(Resource.Id.boxListView)


           
        }
    }
}