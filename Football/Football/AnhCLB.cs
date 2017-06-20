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
    public class CLB
    {
        public int mPhotoID { get; set; }
        public string tenDayDu { get; set; }
        public string ngayThanhLap { get; set; }
        public string sanVanDong { get; set; }
        public string soLuong { get; set; }
    }

    public class AnhCLB
    {
        static CLB[] listCLB =
        {
            new CLB() {mPhotoID = Resource.Drawable.AstonVillaFC, tenDayDu="Tên đầy đủ: Câu lạc bộ bóng đá Aston Villa", ngayThanhLap="Ngày thành lập: 1874", sanVanDong="Sân vận động: Villa Park, Birmingham, Anh", soLuong="Sức chứa: 42.533"},
            new CLB() {mPhotoID = Resource.Drawable.ArsenalFC, tenDayDu="Tên đầy đủ: Câu lạc bộ bóng đá Arsenal", ngayThanhLap="Ngày thành lập: 1886; 131 năm trước với tên Dial Square", sanVanDong="Sân vận động: Emirates", soLuong="Sức chứa: 60,260"},
            new CLB() {mPhotoID = Resource.Drawable.BirminghamCityFC, tenDayDu="Tên đầy đủ: Câu lạc bộ bóng đá Birmingham City", ngayThanhLap="Ngày thành lập: 1875 với tên Small Heath Alliance", sanVanDong="Sân vận động: St Andrew's", soLuong="Sức chứa: 30,016"},
            new CLB() {mPhotoID = Resource.Drawable.Blackburn, tenDayDu="Tên đầy đủ: Câu lạc bộ bóng đá Blackburn Rovers", ngayThanhLap="Ngày thành lập: 1875", sanVanDong="Sân vận động: Ewood Park Blackburn, Anh", soLuong="Sức chứa: 42.533"},
            new CLB() {mPhotoID = Resource.Drawable.BoltonWanderersFC, tenDayDu="Tên đầy đủ: Câu lạc bộ bóng đá Bolton Wanderers F.C.", ngayThanhLap="Ngày thành lập: 1874 (với tên Christ Church FC)", sanVanDong="Sân vận động: Reebok Stadium Burnden Way Horwich Bolton Anh", soLuong="Sức chứa: 28,723"},
            new CLB() {mPhotoID = Resource.Drawable.AFCBournemouth, tenDayDu="Tên đầy đủ: Câu lạc bộ bóng đá A.F.C. Bournemouth", ngayThanhLap="Ngày thành lập: 1890 (as Boscombe St. John's Institute FC but dissolved in 1899 and reformed in 1899 as Boscombe FC)", sanVanDong="Sân vận động: Dean Court, Bournemouth", soLuong="Sức chứa: 12,000"},
            new CLB() {mPhotoID = Resource.Drawable.Chelsea, tenDayDu="Tên đầy đủ: Câu lạc bộ bóng đá Chelsea Football Club", ngayThanhLap="Ngày thành lập: 10 tháng 3, 1905; 112 năm trước", sanVanDong="Sân vận động: Stamford Bridge", soLuong="Sức chứa: 41,631"},
            new CLB() {mPhotoID = Resource.Drawable.EvertonFC, tenDayDu="Tên đầy đủ: Câu lạc bộ bóng đá Everton F.C.", ngayThanhLap="Ngày thành lập: 1878 với tên St. Domingo F.C.", sanVanDong="Sân vận động: Goodison Park Liverpool England", soLuong="Sức chứa: 40.569"},
        };

        private CLB[] clbs;
        Random random;
        public AnhCLB()
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
        public CLB this[int i]
        {
            get { return clbs[i]; }
        }
    }

    public class CLBViewHolder : RecyclerView.ViewHolder
    {
        public ImageView Anh { get; set; }
        public TextView Ten { get; set; }
        public TextView Ngay { get; set; }
        public TextView SVD { get; set; }
        public TextView SoLuong { get; set; }

        public CLBViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            Anh = itemView.FindViewById<ImageView>(Resource.Id.imageView);
            Ten = itemView.FindViewById<TextView>(Resource.Id.txtTen);
            Ngay = itemView.FindViewById<TextView>(Resource.Id.txtNgay);
            SVD = itemView.FindViewById<TextView>(Resource.Id.txtSVD);
            SoLuong = itemView.FindViewById<TextView>(Resource.Id.txtSoLuong);

            itemView.Click += (sender, e) => listener(base.Position);
        }
    }

    public class AnhCLBAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;
        public AnhCLB mAnhCLB;

        public AnhCLBAdapter(AnhCLB anhCLB)
        {
            mAnhCLB = anhCLB;
        }
        public override int ItemCount
        {
            get
            {
                return mAnhCLB.numCLB;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            CLBViewHolder vh = holder as CLBViewHolder;
            vh.Anh.SetImageResource(mAnhCLB[position].mPhotoID);
            vh.Ten.Text = mAnhCLB[position].tenDayDu;
            vh.Ngay.Text = mAnhCLB[position].ngayThanhLap;
            vh.SVD.Text = mAnhCLB[position].sanVanDong;
            vh.SoLuong.Text = mAnhCLB[position].soLuong;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.CLBCard, parent, false);
            CLBViewHolder vh = new CLBViewHolder(itemView, OnClick);
            return vh;
        }

        private void OnClick(int obj)
        {
            if(ItemClick != null)
            {
                ItemClick(this, obj);
            }
        }
    }
}