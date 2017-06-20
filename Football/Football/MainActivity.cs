using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;
using Android.Preferences;
using System;

namespace Football
{
    [Activity(Label = "Football", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btnAnh, btnPhap, btnDuc, btnTBN, btnChauAu, btnChuyenNhuong;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            btnAnh = FindViewById<Button>(Resource.Id.btnAnh);
            btnPhap = FindViewById<Button>(Resource.Id.btnPhap);
            btnDuc = FindViewById<Button>(Resource.Id.btnDuc);
            btnTBN = FindViewById<Button>(Resource.Id.btnTBN);
            btnChauAu = FindViewById<Button>(Resource.Id.btnChauAu);
            btnChuyenNhuong = FindViewById<Button>(Resource.Id.btnChuyenNhuong);

            btnAnh.Click += BtnAnh_Click;
            btnPhap.Click += BtnPhap_Click;
            btnDuc.Click += BtnDuc_Click;
            btnTBN.Click += BtnTBN_Click;
            btnChauAu.Click += BtnChauAu_Click;            
        }

        private void BtnChauAu_Click(object sender, EventArgs e)
        {
            Intent nextActivity = new Intent(this, typeof(ChauAuActivity));
            StartActivity(nextActivity);
        }

        private void BtnTBN_Click(object sender, EventArgs e)
        {
            Intent nextActivity = new Intent(this, typeof(TBNActivity));
            StartActivity(nextActivity);
        }

        private void BtnDuc_Click(object sender, EventArgs e)
        {
            Intent nextActivity = new Intent(this, typeof(DucActivity));
            StartActivity(nextActivity);
        }

        private void BtnPhap_Click(object sender, EventArgs e)
        {
            Intent nextActivity = new Intent(this, typeof(PhapActivity));
            StartActivity(nextActivity);
        }

        private void BtnAnh_Click(object sender, EventArgs e)
        {
            Intent nextActivity = new Intent(this, typeof(AnhActivity));
            StartActivity(nextActivity);
        }
    }
}

