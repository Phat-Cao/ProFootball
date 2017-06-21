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
using Android.Support.V7.Widget;

namespace Football
{
    public class dCLB
    {
        public int mPhotoID { get; set; }
        public string tenDayDu { get; set; }
        public string ngayThanhLap { get; set; }
        public string sanVanDong { get; set; }
        public string soLuong { get; set; }
    }

    public class DucCLB
    {
        static dCLB[] listCLB =
        {
            new dCLB() {mPhotoID = Resource.Drawable.Augsburg, tenDayDu="Tên đầy đủ: Fußball-Club Augsburg 1907 e. V.", ngayThanhLap="Ngày thành lập: 8 August 1907; 109 years ago", sanVanDong="Sân vận động: Augsburg Arena", soLuong="Sức chứa: 30,660"},
            new dCLB() {mPhotoID = Resource.Drawable.Leverkusen, tenDayDu="Tên đầy đủ: Bayer 04 Leverkusen Fußball GmbH", ngayThanhLap="Ngày thành lập: 1 July 1904; 112 years ago", sanVanDong="Sân vận động: 	BayArena", soLuong="Sức chứa: 30,210"},
            new dCLB() {mPhotoID = Resource.Drawable.BayernMunchen, tenDayDu="Tên đầy đủ: Fußball-Club Bayern München e. V.", ngayThanhLap="Ngày thành lập: 27 February 1900; 117 years ago", sanVanDong="Sân vận động: Allianz Arena", soLuong="Sức chứa: 75,000"},
            new dCLB() {mPhotoID = Resource.Drawable.BorussiaDortmund, tenDayDu="Tên đầy đủ: Ballspielverein Borussia 09 e.V. Dortmund", ngayThanhLap="Ngày thành lập: 19 December 1909; 107 years ago", sanVanDong="Sân vận động: Westfalenstadion", soLuong="Sức chứa: 81,359"},
            new dCLB() {mPhotoID = Resource.Drawable.BorussiaMonchengladbach, tenDayDu="Tên đầy đủ: Borussia VfL 1900 Mönchengladbach e.V.", ngayThanhLap="Ngày thành lập: 1 August 1900; 116 years ago", sanVanDong="Sân vận động: Stadion im Borussia-Park", soLuong="Sức chứa: 54,057"},
            new dCLB() {mPhotoID = Resource.Drawable.Darmstadt, tenDayDu="Tên đầy đủ: Sportverein Darmstadt 1898 e.V.", ngayThanhLap="Ngày thành lập: 22 May 1898", sanVanDong="Sân vận động: Jonathan-Heimes-Stadion am Böllenfalltor", soLuong="Sức chứa: 17,400"},
            new dCLB() {mPhotoID = Resource.Drawable.EintrachtFrankfurt, tenDayDu="Tên đầy đủ: Eintracht Frankfurt e.V.", ngayThanhLap="Ngày thành lập: 8 March 1899; 118 years ago", sanVanDong="Sân vận động: Commerzbank-Arena", soLuong="Sức chứa: 51,500"},
            new dCLB() {mPhotoID = Resource.Drawable.HSV, tenDayDu="Tên đầy đủ: Hamburger Sport-Verein e.V.", ngayThanhLap="Ngày thành lập: 29 September 1887; 129 years ago (as SC Germania) 2 June 1919; 98 years ago(as Hamburger SV)", sanVanDong="Sân vận động: Volksparkstadion", soLuong="Sức chứa: 57,000"},
            new dCLB() {mPhotoID = Resource.Drawable.HerthaBSC, tenDayDu="Tên đầy đủ: Hertha, Berliner Sport-Club e.V.", ngayThanhLap="Ngày thành lập: 25 July 1892; 124 years ago", sanVanDong="Sân vận động: Olympiastadion", soLuong="Sức chứa: 74,475"},
            new dCLB() {mPhotoID = Resource.Drawable.TSGHoffenheim, tenDayDu="Tên đầy đủ: Turn- und Sportgemeinschaft 1899 Hoffenheim e.V.", ngayThanhLap="Ngày thành lập: 1 July 1899; 117 years ago", sanVanDong="Sân vận động: Wirsol Rhein-Neckar-Arena", soLuong="Sức chứa: 30,150"},
            new dCLB() {mPhotoID = Resource.Drawable.Ingolstadt04, tenDayDu="Tên đầy đủ: Fußball-Club Ingolstadt 04 e.V.", ngayThanhLap="Ngày thành lập: 5 February 2004; 13 years ago", sanVanDong="Sân vận động: Audi Sportpark", soLuong="Sức chứa: 15,800"},
            new dCLB() {mPhotoID = Resource.Drawable.Cologne, tenDayDu="Tên đầy đủ: 1. Fußball-Club Köln 01/07 e. V.", ngayThanhLap="Ngày thành lập: 13 February 1948; 69 years ago", sanVanDong="Sân vận động: RheinEnergieStadion", soLuong="Sức chứa: 50,374"},
            new dCLB() {mPhotoID = Resource.Drawable.RBLeipzig, tenDayDu="Tên đầy đủ: RasenBallsport Leipzig e.V,", ngayThanhLap="Ngày thành lập: 19 May 2009; 8 years ago", sanVanDong="Sân vận động: Red Bull Arena", soLuong="Sức chứa: 42,959"},
            new dCLB() {mPhotoID = Resource.Drawable.FSVMainz, tenDayDu="Tên đầy đủ: 1. Fußball- und Sport-Verein Mainz 05 e.V.", ngayThanhLap="Ngày thành lập: 16 March 1905; 112 years ago", sanVanDong="Sân vận động: Opel Arena", soLuong="Sức chứa: 34,034"},
            new dCLB() {mPhotoID = Resource.Drawable.Schalke04, tenDayDu="Tên đầy đủ: Fußballclub Gelsenkirchen-Schalke 04 e.V.", ngayThanhLap="Ngày thành lập: 4 May 1904; 113 years ago", sanVanDong="Sân vận động: Veltins-Arena, Gelsenkirchen", soLuong="Sức chứa: 62,271"},
            new dCLB() {mPhotoID = Resource.Drawable.WerderBremen, tenDayDu="Tên đầy đủ: Sportverein Werder Bremen von 1899 e. V.", ngayThanhLap="Ngày thành lập: 4 February 1899; 118 years ago", sanVanDong="Sân vận động: Weserstadion", soLuong="Sức chứa: 42,100"},
            new dCLB() {mPhotoID = Resource.Drawable.VfLWolfsburg, tenDayDu="Tên đầy đủ: Verein für Leibesübungen Wolfsburg Fußball GmbH ", ngayThanhLap="Ngày thành lập: 12 September 1945; 71 years ago", sanVanDong="Sân vận động: Volkswagen Arena", soLuong="Sức chứa: 30,000"},
        };

        private dCLB[] clbs;
        Random random;

        public DucCLB()
        {
            this.clbs = listCLB;
            random = new Random();
        }

        public int numCLB
        {
            get
            {
                return clbs.Length;
            }
        }
        public dCLB this[int i]
        {
            get { return clbs[i]; }
        }
    }

    public class DucCLBAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;
        public DucCLB mDucCLB;

        public DucCLBAdapter(DucCLB ducCLB)
        {
            mDucCLB = ducCLB;
        }

        public override int ItemCount
        {
            get
            {
                return mDucCLB.numCLB;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            CLBViewHolder vh = holder as CLBViewHolder;
            vh.Anh.SetImageResource(mDucCLB[position].mPhotoID);
            vh.Ten.Text = mDucCLB[position].tenDayDu;
            vh.Ngay.Text = mDucCLB[position].ngayThanhLap;
            vh.SVD.Text = mDucCLB[position].sanVanDong;
            vh.SoLuong.Text = mDucCLB[position].soLuong;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.CLBCard, parent, false);
            CLBViewHolder vh = new CLBViewHolder(itemView, OnClick);
            return vh;
        }

        private void OnClick(int obj)
        {
            if (ItemClick != null)
            {
                ItemClick(this, obj);
            }
        }
    }
}