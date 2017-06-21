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
    public class tCLB
    {
        public int mPhotoID { get; set; }
        public string tenDayDu { get; set; }
        public string ngayThanhLap { get; set; }
        public string sanVanDong { get; set; }
        public string soLuong { get; set; }
    } 

    public class TBNCLB
    {
        static tCLB[] listCLB =
        {
            new tCLB() {mPhotoID = Resource.Drawable.DeportivoAlaves, tenDayDu="Tên đầy đủ: Deportivo Alavés, S.A.D.", ngayThanhLap="Ngày thành lập: 1921; 96 years ago", sanVanDong="Sân vận động: Mendizorrotza", soLuong="Sức chứa: 19,840"},
            new tCLB() {mPhotoID = Resource.Drawable.AthleticBilbao, tenDayDu="Tên đầy đủ: Athletic Club", ngayThanhLap="Ngày thành lập: 1898; 119 years ago", sanVanDong="Sân vận động: San Mamés", soLuong="Sức chứa: 53,289"},
            new tCLB() {mPhotoID = Resource.Drawable.AtleticoMadrid, tenDayDu="Tên đầy đủ: Club Atlético de Madrid, S.A.D.", ngayThanhLap="Ngày thành lập: 26 April 1903; 114 years ago as Athletic Club de Madrid", sanVanDong="Sân vận động: Wanda Metropolitano", soLuong="Sức chứa: 68,000"},
            new tCLB() {mPhotoID = Resource.Drawable.Barcelona, tenDayDu="Tên đầy đủ: Futbol Club Barcelona", ngayThanhLap="Ngày thành lập: 29 November 1899; 117 years ago as Foot-Ball Club Barcelona", sanVanDong="Sân vận động: Camp Nou", soLuong="Sức chứa: 99,354"},
            new tCLB() {mPhotoID = Resource.Drawable.CeltadeVigo, tenDayDu="Tên đầy đủ: Real Club Celta de Vigo, S.A.D.", ngayThanhLap="Ngày thành lập: 23 August 1923; 93 years ago", sanVanDong="Sân vận động: Balaídos", soLuong="Sức chứa: 29,000"},
            new tCLB() {mPhotoID = Resource.Drawable.DeportivoLaCorua, tenDayDu="Tên đầy đủ: Real Club Deportivo de La Coruña, S.A.D.", ngayThanhLap="Ngày thành lập: 2 March 1906; 111 years ago", sanVanDong="Sân vận động: Estadio Riazor", soLuong="Sức chứa: 32,912"},
            new tCLB() {mPhotoID = Resource.Drawable.Eibar, tenDayDu="Tên đầy đủ: Sociedad Deportiva Eibar, S.A.D.", ngayThanhLap="Ngày thành lập: 1 January 1940; 77 years ago", sanVanDong="Sân vận động: Ipurua Municipal Stadium, Eibar", soLuong="Sức chứa: 7,083"},
            new tCLB() {mPhotoID = Resource.Drawable.espanyol, tenDayDu="Tên đầy đủ: Reial Club Deportiu Espanyol de Barcelona, S.A.D.", ngayThanhLap="Ngày thành lập: 28 October 1900; 116 years ago as Sociedad Española de Football", sanVanDong="Sân vận động: RCDE Stadium", soLuong="Sức chứa: 40,500"},
            new tCLB() {mPhotoID = Resource.Drawable.LasPalmas, tenDayDu="Tên đầy đủ: Unión Deportiva Las Palmas, S.A.D.", ngayThanhLap="Ngày thành lập: 1949", sanVanDong="Sân vận động: Estadio Gran Canaria", soLuong="Sức chứa: 32,150"},
            new tCLB() {mPhotoID = Resource.Drawable.Leganes, tenDayDu="Tên đầy đủ: Club Deportivo Leganés, S.A.D.", ngayThanhLap="Ngày thành lập: 1928; 89 years ago", sanVanDong="Sân vận động: 	Estadio Municipal de Butarque", soLuong="Sức chứa: 10,954"},
            new tCLB() {mPhotoID = Resource.Drawable.Malaga, tenDayDu="Tên đầy đủ: Málaga Club de Fútbol", ngayThanhLap="Ngày thành lập: 1904; 113 years ago", sanVanDong="Sân vận động: La Rosaleda", soLuong="Sức chứa: 30,044"},
            new tCLB() {mPhotoID = Resource.Drawable.Osasuna, tenDayDu="Tên đầy đủ: Club Atlético Osasuna", ngayThanhLap="Ngày thành lập: 24 October 1920; 96 years ago", sanVanDong="Sân vận động: El Sadar", soLuong="Sức chứa: 18,761"},
            new tCLB() {mPhotoID = Resource.Drawable.Realbetis, tenDayDu="Tên đầy đủ: Real Betis Balompié, SAD", ngayThanhLap="Ngày thành lập: 12 September 1907; 109 years ago", sanVanDong="Sân vận động: Benito Villamarín", soLuong="Sức chứa: 52,500 "},
            new tCLB() {mPhotoID = Resource.Drawable.RealMadrid, tenDayDu="Tên đầy đủ: Real Madrid Club de Fútbol", ngayThanhLap="Ngày thành lập: 6 March 1902; 115 years ago as Madrid Football Club", sanVanDong="Sân vận động: Santiago Bernabéu Stadium", soLuong="Sức chứa: 81,044"},
            new tCLB() {mPhotoID = Resource.Drawable.RealSociedad, tenDayDu="Tên đầy đủ: Real Sociedad de Fútbol, S.A.D", ngayThanhLap="Ngày thành lập: 7 September 1909; 107 years ago", sanVanDong="Sân vận động: Anoeta", soLuong="Sức chứa: 32,200"},
            new tCLB() {mPhotoID = Resource.Drawable.Sevilla, tenDayDu="Tên đầy đủ: Sevilla Fútbol Club SAD", ngayThanhLap="Ngày thành lập: 25 January 1890; 127 years ago as recognised by LFP, UEFA and FIFA", sanVanDong="Sân vận động: Ramón Sánchez Pizjuán", soLuong="Sức chứa: 42,500"},
            new tCLB() {mPhotoID = Resource.Drawable.Valencia, tenDayDu="Tên đầy đủ: Valencia Club de Fútbol, SAD", ngayThanhLap="Ngày thành lập: 18 March 1919; 98 years ago", sanVanDong="Sân vận động: Mestalla Stadium", soLuong="Sức chứa: 55,000"},
        };

        private tCLB[] clbs;
        Random random;

        public TBNCLB()
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
        public tCLB this[int i]
        {
            get { return clbs[i]; }
        }
    }

    public class TBNCLBAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;
        public TBNCLB mTBNCLB;

        public TBNCLBAdapter(TBNCLB tbnCLB)
        {
            mTBNCLB = tbnCLB;
        }

        public override int ItemCount
        {
            get
            {
                return mTBNCLB.numCLB;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            CLBViewHolder vh = holder as CLBViewHolder;
            vh.Anh.SetImageResource(mTBNCLB[position].mPhotoID);
            vh.Ten.Text = mTBNCLB[position].tenDayDu;
            vh.Ngay.Text = mTBNCLB[position].ngayThanhLap;
            vh.SVD.Text = mTBNCLB[position].sanVanDong;
            vh.SoLuong.Text = mTBNCLB[position].soLuong;
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