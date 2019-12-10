using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;

namespace UCRouteAssist.Droid
{
    class MapFrag : Fragment
    {
        private GoogleMap googleMap;
        
        /*FragmentActivity listener;

        public void override OnAttach(Context context)
        {
            base.OnAttach(context);
            if (context is Activity)
            {
                this.listener = (FragmentActivity)context;

            }

        }
        */
        public override View OnCreateView(LayoutInflater inflater, ViewGroup parent, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.map_layout, parent, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
           
        }

        
    }
}