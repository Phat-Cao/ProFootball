using System.Text;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Football.Model;
using Football.Common;
using Newtonsoft.Json;
using Football.Adapter;

namespace Football
{
    [Activity(Label = "ChuyenNhuongActivity", Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class ChuyenNhuongActivity : AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar toolbar;
        RecyclerView recyclerView;
        RssObject rssObject;

        private const string RSS_link = "http://bongda24h.vn/RSS/187.rss";
        private const string RSS_to_json = "https://api.rss2json.com/v1/api.json?rss_url=";

        //create menu for app
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.Main_Menu, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Resource.Id.menu_refresh)
                LoadData();
            return true;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ChuyenNhuongActivity);
            // Create your application here
            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            toolbar.Title = "Thông tin chuyển nhượng";
            SetSupportActionBar(toolbar);

            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.Vertical, false);
            recyclerView.SetLayoutManager(linearLayoutManager);
            LoadData();
        }

        //Proccess data, Build url to get json from rss and call async task
        private void LoadData()
        {
            StringBuilder strBuilder = new StringBuilder(RSS_to_json);
            strBuilder.Append(RSS_link);

            new LoadDataASync(this).Execute(strBuilder.ToString());
        }

        class LoadDataASync : AsyncTask<string, string, string>
        {
            ChuyenNhuongActivity cnActivity;
            ProgressDialog mDialog;

            public LoadDataASync(ChuyenNhuongActivity cnActivity)
            {
                this.cnActivity = cnActivity;
            }

            protected override void OnPreExecute()
            {
                mDialog = new ProgressDialog(cnActivity);
                mDialog.Window.SetType(Android.Views.WindowManagerTypes.SystemAlert);
                mDialog.SetMessage("Please Wait...");
                mDialog.Show();
            }

            protected override string RunInBackground(params string[] @params)
            {
                string result = new HTTPDataHandler().GetHTTPData(@params[0]);
                return result;
            }

            //Convert json to object
            protected override void OnPostExecute(string result)
            {
                RssObject data = JsonConvert.DeserializeObject<RssObject>(result);
                mDialog.Dismiss();
                FeedAdapter adapter = new FeedAdapter(data, cnActivity);
                cnActivity.recyclerView.SetAdapter(adapter);
                adapter.NotifyDataSetChanged();
            }
        }
    }
}