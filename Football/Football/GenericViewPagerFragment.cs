using System;
using Android.OS;
using Android.Views;
using Android.Support.V4.App;

namespace Football
{
    //File Giao dien Fragment, dung de hien thi giao dien
    public class GenericViewPagerFragment : Fragment
    {
        private Func<LayoutInflater, ViewGroup, Bundle, View> _view;
        public GenericViewPagerFragment(Func<LayoutInflater, ViewGroup, Bundle, View> view)
        {
            _view = view;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return _view(inflater, container, savedInstanceState);
        }
    }
}