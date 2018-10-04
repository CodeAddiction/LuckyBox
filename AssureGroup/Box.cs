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
    class Box
    {
        public int BoxImage { get; set; }
        public string BoxLabel { get; set; }
        public string BoxPrice { get; set; }

        public Box(int boxImage, string boxLabel, string boxPrice)
        {
            this.BoxImage = boxImage;
            this.BoxLabel = boxLabel;
            this.BoxPrice = boxPrice;

        }
    }
}