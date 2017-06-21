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
    public class yCLB
    {
        public int mPhotoID { get; set; }
        public string tenDayDu { get; set; }
        public string ngayThanhLap { get; set; }
        public string sanVanDong { get; set; }
        public string soLuong { get; set; }
    }

    public class YCLB
    {
        static yCLB[] listCLB =
        {
            new yCLB() {mPhotoID = Resource.Drawable.AtalantaBC, tenDayDu="Tên đầy đủ: Atalanta Bergamasca Calcio S.p.A.", ngayThanhLap="Ngày thành lập: 8 October 1907; 109 years ago", sanVanDong="Sân vận động: Stadio Atleti Azzurri d'Italia", soLuong="Sức chứa: 26,562"},
            new yCLB() {mPhotoID = Resource.Drawable.BeneventoCalcio, tenDayDu="Tên đầy đủ: Benevento Calcio SRL", ngayThanhLap="Ngày thành lập: 1929, 2005 (refounded)", sanVanDong="Sân vận động: Stadio Ciro Vigorito, Benevento, Italy", soLuong="Sức chứa: 12,847"},
            new yCLB() {mPhotoID = Resource.Drawable.Bologna, tenDayDu="Tên đầy đủ: Bologna Football Club 1909 S.p.A.", ngayThanhLap="Ngày thành lập: 3 October 1909; 107 years ago", sanVanDong="Sân vận động: Stadio Renato Dall'Ara", soLuong="Sức chứa: 38,279"},
            new yCLB() {mPhotoID = Resource.Drawable.CagliariCalcio, tenDayDu="Tên đầy đủ: Cagliari Calcio S.p.A.", ngayThanhLap="Ngày thành lập: 30 May 1920; 97 years ago", sanVanDong="Sân vận động: Sardegna Arena", soLuong="Sức chứa: 16,233"},
            new yCLB() {mPhotoID = Resource.Drawable.Chievoverona, tenDayDu="Tên đầy đủ: Associazione Calcio ChievoVerona S.r.l.", ngayThanhLap="Ngày thành lập: 1929; 88 years ago", sanVanDong="Sân vận động: Stadio Marc'Antonio Bentegodi", soLuong="Sức chứa: 39,371"},
            new yCLB() {mPhotoID = Resource.Drawable.Crotone, tenDayDu="Tên đầy đủ: Football Club Crotone", ngayThanhLap="Ngày thành lập: 1910; 107 years ago", sanVanDong="Sân vận động: Ezio Scida", soLuong="Sức chứa: 16,547"},
            new yCLB() {mPhotoID = Resource.Drawable.Fiorentina, tenDayDu="Tên đầy đủ: ACF Fiorentina S.p.A.", ngayThanhLap="Ngày thành lập: 29 August 1926; 90 years ago August 2002; 14 years ago as A.C.Fiorentina e Florentia Viola", sanVanDong="Sân vận động: Stadio Artemio Franchi", soLuong="Sức chứa: 43,147"},
            new yCLB() {mPhotoID = Resource.Drawable.Genoa, tenDayDu="Tên đầy đủ: Genoa Cricket and Football Club S.p.A.", ngayThanhLap="Ngày thành lập: 1893; 124 years ago", sanVanDong="Sân vận động: Stadio Luigi Ferraris", soLuong="Sức chứa: 36,599"},
            new yCLB() {mPhotoID = Resource.Drawable.Verona, tenDayDu="Tên đầy đủ: Hellas Verona Football Club", ngayThanhLap="Ngày thành lập: 1903; 114 years ago", sanVanDong="Sân vận động: Stadio Marc'Antonio Bentegodi, Verona", soLuong="Sức chứa: 39,371"},
            new yCLB() {mPhotoID = Resource.Drawable.InterMilan, tenDayDu="Tên đầy đủ: Football Club Internazionale Milano S.p.A.", ngayThanhLap="Ngày thành lập: 9 March 1908; 109 years ago", sanVanDong="Sân vận động: San Siro", soLuong="Sức chứa: 80,018"},
            new yCLB() {mPhotoID = Resource.Drawable.Juventus, tenDayDu="Tên đầy đủ: Juventus Football Club S.p.A.", ngayThanhLap="Ngày thành lập: 1 November 1897; 119 years ago, as Sport-Club Juventus", sanVanDong="Sân vận động: Juventus Stadium", soLuong="Sức chứa: 41,507"},
            new yCLB() {mPhotoID = Resource.Drawable.Lazio, tenDayDu="Tên đầy đủ: Società Sportiva Lazio S.p.A.", ngayThanhLap="Ngày thành lập: 9 January 1900; 117 years ago, as Società Podistica Lazio", sanVanDong="Sân vận động: Stadio Olimpico", soLuong="Sức chứa: 70,634"},
            new yCLB() {mPhotoID = Resource.Drawable.Milan, tenDayDu="Tên đầy đủ: Associazione Calcio Milan S.p.A.", ngayThanhLap="Ngày thành lập: 13 December 1899; 117 years ago", sanVanDong="Sân vận động: San Siro", soLuong="Sức chứa: 80,018"},
            new yCLB() {mPhotoID = Resource.Drawable.Napoli, tenDayDu="Tên đầy đủ: Società Sportiva Calcio Napoli S.p.A.", ngayThanhLap="Ngày thành lập: 1 August 1926; 90 years ago (as Associazione Calcio Napoli)", sanVanDong="Sân vận động: Stadio San Paolo", soLuong="Sức chứa: 60,240"},
            new yCLB() {mPhotoID = Resource.Drawable.Roma, tenDayDu="Tên đầy đủ: Associazione Sportiva Roma S.p.A.", ngayThanhLap="Ngày thành lập: 7 June 1927; 90 years ago (by Italo Foschi)", sanVanDong="Sân vận động: Stadio Olimpico", soLuong="Sức chứa: 70,634"},
            new yCLB() {mPhotoID = Resource.Drawable.Sampdoria, tenDayDu="Tên đầy đủ: Unione Calcio Sampdoria S.p.A.", ngayThanhLap="Ngày thành lập: 12 August 1946; 70 years ago", sanVanDong="Sân vận động: Stadio Luigi Ferraris", soLuong="Sức chứa: 36,600"},
            new yCLB() {mPhotoID = Resource.Drawable.Sassuolo, tenDayDu="Tên đầy đủ: Unione Sportiva Sassuolo Calcio Srl", ngayThanhLap="Ngày thành lập: 17 July 1920; 96 years ago", sanVanDong="Sân vận động: Mapei Stadium-Città del Tricolore (official match), Stadio Enzo Ricci (training ground)", soLuong="Sức chứa: 23,717"},
        };

        private yCLB[] clbs;
        Random random;

        public YCLB()
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
        public yCLB this[int i]
        {
            get { return clbs[i]; }
        }
    }

    public class YCLBAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;
        public YCLB mYCLB;

        public YCLBAdapter(YCLB yCLB)
        {
            mYCLB = yCLB;
        }

        public override int ItemCount
        {
            get
            {
                return mYCLB.numCLB;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            CLBViewHolder vh = holder as CLBViewHolder;
            vh.Anh.SetImageResource(mYCLB[position].mPhotoID);
            vh.Ten.Text = mYCLB[position].tenDayDu;
            vh.Ngay.Text = mYCLB[position].ngayThanhLap;
            vh.SVD.Text = mYCLB[position].sanVanDong;
            vh.SoLuong.Text = mYCLB[position].soLuong;
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