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
    [Activity(Label = "Register")]
    public class Register : Activity
    {

        TextView _dateDisplay;
        Button _dateSelectButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.register);


            _dateDisplay = FindViewById<TextView>(Resource.Id.dobTV);
            _dateSelectButton = FindViewById<Button>(Resource.Id.date_select_button);
            _dateSelectButton.Click += DateSelect_OnClick;

        }
        void DateSelect_OnClick(object sender, EventArgs eventArgs)
        {
            DatePickerFragment frag = DatePickerFragment.NewInstance(delegate (DateTime time)
            {
                _dateDisplay.Text = time.ToLongDateString();
            });
            frag.Show(FragmentManager, DatePickerFragment.TAG);
        }

    }
}