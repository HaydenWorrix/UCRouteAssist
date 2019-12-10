
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Fragment = Android.Support.V4.App.FragmentActivity;
using Android.Content;
using Android.Support.V7.App;

namespace UCRouteAssist.Droid
{
    [Activity(Label = "UCRouteAssist", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : AppCompatActivity, IOnMapReadyCallback

    {
        private GoogleMap googleMap;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            //TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            //global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //global::Xamarin.FormsMaps.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.main_activity_layout);
            if (savedInstanceState == null)
            {
                SupportMapFragment supportMapFragment = (SupportMapFragment)SupportFragmentManager
               .FindFragmentById(Resource.Id.map);
                supportMapFragment.GetMapAsync();
            }

            
            //Intent intent = new Intent(this, typeof(MapFragmentActivity));
            //StartActivity(intent);


            //LoadApplication(new App());
        }
        public void OnMapReady(GoogleMap googleMap)
        {
            this.googleMap = googleMap;
            LatLng cincinnati = new LatLng(39, -84);
            this.googleMap.AddMarker(new MarkerOptions().SetPosition(cincinnati).SetTitle("Test"));
            this.googleMap.MoveCamera(CameraUpdateFactory.NewLatLng(cincinnati));
        }
    }
}