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
using Android.Graphics;

namespace Football
{
    [Activity(Label = "MyIntro", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = true)]
    public class MyIntro : AppIntro.AppIntro
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            AddSlide(AppIntro.AppIntroFragment.NewInstance("Football News",
               "Cập nhật thông tin các giải đấu nhanh chóng",
               Resource.Drawable.flamingfootball,
               Color.ParseColor("#0099CC")));

            AddSlide(AppIntro.AppIntroFragment.NewInstance("Football News",
                "Cập nhật thông tin chuyển nhượng chính xác",
                Resource.Drawable.footballfieldinperspective,
                Color.ParseColor("#6666CC")));

            AddSlide(AppIntro.AppIntroFragment.NewInstance("Football News",
                "Tổng hợp các video clip hay về bóng đá",
                Resource.Drawable.footballtrophy,
                Color.ParseColor("#6633CC")));

            ShowStatusBar(false);
            SetBarColor(Color.ParseColor("#333639"));
            SetSeparatorColor(Color.ParseColor("#2196F3"));
        }

        public override void OnDonePressed()
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
        }

        public override void OnSkipPressed()
        {
            Toast.MakeText(this, "Skip Clicked", ToastLength.Short).Show();
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
        }

        public override void OnSlideChanged()
        {
            Toast.MakeText(this, "Slide Changed", ToastLength.Short).Show();
        }
    }
}