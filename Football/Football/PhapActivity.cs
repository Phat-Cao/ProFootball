﻿
using Android.App;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using Android.Support.V7.App;
using Football.Adapter;
using Football.Common;
using Football.Model;
using Newtonsoft.Json;
using System.Text;

namespace Football
{
    [Activity(Label = "Bóng đá Pháp")]
    public class PhapActivity : FragmentActivity
    {
        RecyclerView recyclerView;
        RssObject rssObject;

        private const string RSS_link = "http://bongda24h.vn/RSS/197.rss";
        private const string RSS_to_json = "https://api.rss2json.com/v1/api.json?rss_url=";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PhapActivity);

            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            var pager = FindViewById<ViewPager>(Resource.Id.pager);
            var adapter = new GenericFragmentPagerAdapter(SupportFragmentManager);

            adapter.AddFragmentView((i, v, b) =>
            {
                var view = i.Inflate(Resource.Layout.tab, v, false);
                recyclerView = view.FindViewById<RecyclerView>(Resource.Id.recyclerView);
                LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.Vertical, false);
                recyclerView.SetLayoutManager(linearLayoutManager);
                LoadData();
                return view;
            });

            adapter.AddFragmentView((i, v, b) =>
            {
                var view = i.Inflate(Resource.Layout.tab, v, false);

                return view;
            });

            pager.Adapter = adapter;
            pager.SetOnPageChangeListener(new ViewPageListenerForActionBar(ActionBar));

            ActionBar.AddTab(pager.GetViewPageTab(ActionBar, "Tin Tức"));
            ActionBar.AddTab(pager.GetViewPageTab(ActionBar, "Second Tab"));
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
            PhapActivity phapActivity;
            ProgressDialog mDialog;

            public LoadDataASync(PhapActivity phapActivity)
            {
                this.phapActivity = phapActivity;
            }

            protected override void OnPreExecute()
            {
                mDialog = new ProgressDialog(phapActivity);
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
                FeedAdapter adapter = new FeedAdapter(data, phapActivity);
                phapActivity.recyclerView.SetAdapter(adapter);
                adapter.NotifyDataSetChanged();
            }
        }
    }
}