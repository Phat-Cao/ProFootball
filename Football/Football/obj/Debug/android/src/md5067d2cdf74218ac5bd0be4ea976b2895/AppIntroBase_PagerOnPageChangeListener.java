package md5067d2cdf74218ac5bd0be4ea976b2895;


public class AppIntroBase_PagerOnPageChangeListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.v4.view.ViewPager.OnPageChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPageScrollStateChanged:(I)V:GetOnPageScrollStateChanged_IHandler:Android.Support.V4.View.ViewPager/IOnPageChangeListenerInvoker, Xamarin.Android.Support.Core.UI\n" +
			"n_onPageScrolled:(IFI)V:GetOnPageScrolled_IFIHandler:Android.Support.V4.View.ViewPager/IOnPageChangeListenerInvoker, Xamarin.Android.Support.Core.UI\n" +
			"n_onPageSelected:(I)V:GetOnPageSelected_IHandler:Android.Support.V4.View.ViewPager/IOnPageChangeListenerInvoker, Xamarin.Android.Support.Core.UI\n" +
			"";
		mono.android.Runtime.register ("AppIntro.AppIntroBase+PagerOnPageChangeListener, AppIntro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AppIntroBase_PagerOnPageChangeListener.class, __md_methods);
	}


	public AppIntroBase_PagerOnPageChangeListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AppIntroBase_PagerOnPageChangeListener.class)
			mono.android.TypeManager.Activate ("AppIntro.AppIntroBase+PagerOnPageChangeListener, AppIntro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public AppIntroBase_PagerOnPageChangeListener (md5067d2cdf74218ac5bd0be4ea976b2895.AppIntroBase p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == AppIntroBase_PagerOnPageChangeListener.class)
			mono.android.TypeManager.Activate ("AppIntro.AppIntroBase+PagerOnPageChangeListener, AppIntro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "AppIntro.AppIntroBase, AppIntro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onPageScrollStateChanged (int p0)
	{
		n_onPageScrollStateChanged (p0);
	}

	private native void n_onPageScrollStateChanged (int p0);


	public void onPageScrolled (int p0, float p1, int p2)
	{
		n_onPageScrolled (p0, p1, p2);
	}

	private native void n_onPageScrolled (int p0, float p1, int p2);


	public void onPageSelected (int p0)
	{
		n_onPageSelected (p0);
	}

	private native void n_onPageSelected (int p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
