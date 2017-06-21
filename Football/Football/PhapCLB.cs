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
    public class pCLB
    {
        public int mPhotoID { get; set; }
        public string tenDayDu { get; set; }
        public string ngayThanhLap { get; set; }
        public string sanVanDong { get; set; }
        public string soLuong { get; set; }
    }

    public class PhapCLB
    {
        static pCLB[] listCLB =
        {
            new pCLB() {mPhotoID = Resource.Drawable.angers, tenDayDu="Tên đầy đủ: Câu lạc bộ bóng đá Angers", ngayThanhLap="Ngày thành lập: 1919; 98 years ago", sanVanDong="Sân vận động: Stade Raymond Kopa, Angers", soLuong="Sức chứa: 18,000"},
            new pCLB() {mPhotoID = Resource.Drawable.Bastia, tenDayDu="Tên đầy đủ: Sporting Club de Bastia", ngayThanhLap="Ngày thành lập: 1905; 112 years ago", sanVanDong="Sân vận động: Stade Armand Cesari", soLuong="Sức chứa: 16,480"},
            new pCLB() {mPhotoID = Resource.Drawable.Bordeaux, tenDayDu="Tên đầy đủ: Football Club des Girondins de Bordeaux", ngayThanhLap="Ngày thành lập: 1881; 136 years ago", sanVanDong="Sân vận động: Matmut Atlantique, Bordeaux, France", soLuong="Sức chứa: 42,115"},
            new pCLB() {mPhotoID = Resource.Drawable.SMCaen, tenDayDu="Tên đầy đủ: Stade Malherbe Caen", ngayThanhLap="Ngày thành lập: 17 November 1913; 103 years ago", sanVanDong="Sân vận động: Stade Michel d'Ornano, Caen, Normandie", soLuong="Sức chứa: 21,500"},
            new pCLB() {mPhotoID = Resource.Drawable.DijonFCO, tenDayDu="Tên đầy đủ: Dijon Football Côte-d'Or", ngayThanhLap="Ngày thành lập: 1998; 19 years ago", sanVanDong="Sân vận động: Stade Gaston Gérard, Dijon", soLuong="Sức chứa: 15,995"},
            new pCLB() {mPhotoID = Resource.Drawable.Guingamp, tenDayDu="Tên đầy đủ: En Avant de Guingamp Côtes-d'Armor", ngayThanhLap="Ngày thành lập: 1912; 105 years ago", sanVanDong="Sân vận động: Stade de Roudourou, Guingamp", soLuong="Sức chứa: 18,250"},
            new pCLB() {mPhotoID = Resource.Drawable.Lille, tenDayDu="Tên đầy đủ: Lille Olympique Sporting Club", ngayThanhLap="Ngày thành lập: 23 September 1944; 72 years ago", sanVanDong="Sân vận động: Stade Pierre-Mauroy", soLuong="Sức chứa: 50,186"},
            new pCLB() {mPhotoID = Resource.Drawable.Lorient, tenDayDu="Tên đầy đủ: Football Club Lorient-Bretagne Sud", ngayThanhLap="Ngày thành lập: 1926; 91 years ago", sanVanDong="Sân vận động: Stade du Moustoir, Lorient", soLuong="Sức chứa: 18,500"},
            new pCLB() {mPhotoID = Resource.Drawable.Lyonnais, tenDayDu="Tên đầy đủ: Olympique Lyonnais", ngayThanhLap="Ngày thành lập: 1950; 67 years ago", sanVanDong="Sân vận động: Parc Olympique Lyonnais", soLuong="Sức chứa: 59,186"},
            new pCLB() {mPhotoID = Resource.Drawable.Marseille, tenDayDu="Tên đầy đủ: Olympique de Marseille", ngayThanhLap="Ngày thành lập: 31 August 1899; 117 years ago", sanVanDong="Sân vận động: Stade Vélodrome", soLuong="Sức chứa: 67,394"},
            new pCLB() {mPhotoID = Resource.Drawable.Metz, tenDayDu="Tên đầy đủ: Football Club de Metz", ngayThanhLap="Ngày thành lập: 1932; 85 years ago", sanVanDong="Sân vận động: Stade Saint-Symphorien, Metz", soLuong="Sức chứa: 25,636"},
            new pCLB() {mPhotoID = Resource.Drawable.ASMonaco, tenDayDu="Tên đầy đủ: Association Sportive de Monaco Football Club", ngayThanhLap="Ngày thành lập: 23 August 1924; 92 years ago", sanVanDong="Sân vận động: Stade Louis II", soLuong="Sức chứa: 26,768"},
            new pCLB() {mPhotoID = Resource.Drawable.Montpellier, tenDayDu="Tên đầy đủ: Montpellier Hérault Sport Club", ngayThanhLap="Ngày thành lập: 1974; 43 years ago", sanVanDong="Sân vận động: Stade de la Mosson", soLuong="Sức chứa: 32,900"},
            new pCLB() {mPhotoID = Resource.Drawable.ASNancyLorraine, tenDayDu="Tên đầy đủ: Association Sportive Nancy-Lorraine", ngayThanhLap="Ngày thành lập: 1967; 50 years ago", sanVanDong="Sân vận động: Stade Marcel Picot, Tomblaine", soLuong="Sức chứa: 20,087"},
            new pCLB() {mPhotoID = Resource.Drawable.Nantes, tenDayDu="Tên đầy đủ: Football Club de Nantes", ngayThanhLap="Ngày thành lập: 1943; 74 years ago", sanVanDong="Sân vận động: La Beaujoire-Louis Fonteneau", soLuong="Sức chứa: 	38,004"},
            new pCLB() {mPhotoID = Resource.Drawable.Nice, tenDayDu="Tên đầy đủ: Olympique Gymnaste Club Nice Côte d'Azur", ngayThanhLap="Ngày thành lập: 9 July 1904; 112 years ago as Le Gymnaste Club de Nice", sanVanDong="Sân vận động: Allianz Riviera", soLuong="Sức chứa: 35,624"},
            new pCLB() {mPhotoID = Resource.Drawable.ParisSaintGermain, tenDayDu="Tên đầy đủ: Paris Saint-Germain Football Club", ngayThanhLap="Ngày thành lập: 1970; 47 years ago", sanVanDong="Sân vận động: Parc des Princes", soLuong="Sức chứa: 48,712"},
        };

        private pCLB[] clbs;
        Random random;

        public PhapCLB()
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
        public pCLB this[int i]
        {
            get { return clbs[i]; }
        }
    }

    public class PhapCLBAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;
        public PhapCLB mPhapCLB;

        public PhapCLBAdapter(PhapCLB phapCLB)
        {
            mPhapCLB = phapCLB;
        }

        public override int ItemCount
        {
            get
            {
                return mPhapCLB.numCLB;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            CLBViewHolder vh = holder as CLBViewHolder;
            vh.Anh.SetImageResource(mPhapCLB[position].mPhotoID);
            vh.Ten.Text = mPhapCLB[position].tenDayDu;
            vh.Ngay.Text = mPhapCLB[position].ngayThanhLap;
            vh.SVD.Text = mPhapCLB[position].sanVanDong;
            vh.SoLuong.Text = mPhapCLB[position].soLuong;
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