using Android.App;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V7.App;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using Football.Model;
using Football.Common;
using Newtonsoft.Json;
using Football.Adapter;
using System.Text;
using System;
using Android.Widget;

namespace Football
{
    [Activity(Label = "Bóng đá Ý")]
    public class YActivity : FragmentActivity
    {
        RecyclerView recyclerView, recyclerView1;
        RssObject rssObject;
        RecyclerView.LayoutManager layoutManager;
        YCLB yCLB;
        YCLBAdapter clbAdapter;

        private const string RSS_link = "http://bongda24h.vn/RSS/176.rss";
        private const string RSS_to_json = "https://api.rss2json.com/v1/api.json?rss_url=";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            yCLB = new YCLB();
            SetContentView(Resource.Layout.YActivity);

            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            var pager = FindViewById<ViewPager>(Resource.Id.pager);
            var adapter = new GenericFragmentPagerAdapter(SupportFragmentManager);

            adapter.AddFragmentView((i, v, b) => {
                var view = i.Inflate(Resource.Layout.tab, v, false);
                recyclerView = view.FindViewById<RecyclerView>(Resource.Id.recyclerView);
                LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.Vertical, false);
                recyclerView.SetLayoutManager(linearLayoutManager);
                LoadData();
                return view;
            });

            adapter.AddFragmentView((i, v, b) => {
                var view = i.Inflate(Resource.Layout.tab, v, false);
                recyclerView1 = view.FindViewById<RecyclerView>(Resource.Id.recyclerView);
                layoutManager = new LinearLayoutManager(this);
                recyclerView1.SetLayoutManager(layoutManager);
                clbAdapter = new YCLBAdapter(yCLB);
                clbAdapter.ItemClick += ClbAdapter_ItemClick;
                recyclerView1.SetAdapter(clbAdapter);
                return view;
            });

            pager.Adapter = adapter;
            pager.SetOnPageChangeListener(new ViewPageListenerForActionBar(ActionBar));

            ActionBar.AddTab(pager.GetViewPageTab(ActionBar, "Tin Tức"));
            ActionBar.AddTab(pager.GetViewPageTab(ActionBar, "Đội Bóng"));
        }

        private void ClbAdapter_ItemClick(object sender, int e)
        {
            int photoNum = e + 1;
            Toast.MakeText(this, "This is photo number " + photoNum, ToastLength.Short).Show();
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
            YActivity yActivity;
            ProgressDialog mDialog;

            public LoadDataASync(YActivity yActivity)
            {
                this.yActivity = yActivity;
            }

            protected override void OnPreExecute()
            {
                mDialog = new ProgressDialog(yActivity);
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
                FeedAdapter adapter = new FeedAdapter(data, yActivity);
                yActivity.recyclerView.SetAdapter(adapter);
                adapter.NotifyDataSetChanged();
            }
        }
    }
}