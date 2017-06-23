package md5067d2cdf74218ac5bd0be4ea976b2895;


public class ScrollerCustomDuration
	extends android.widget.Scroller
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_startScroll:(IIIII)V:GetStartScroll_IIIIIHandler\n" +
			"";
		mono.android.Runtime.register ("AppIntro.ScrollerCustomDuration, AppIntro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ScrollerCustomDuration.class, __md_methods);
	}


	public ScrollerCustomDuration (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == ScrollerCustomDuration.class)
			mono.android.TypeManager.Activate ("AppIntro.ScrollerCustomDuration, AppIntro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public ScrollerCustomDuration (android.content.Context p0, android.view.animation.Interpolator p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == ScrollerCustomDuration.class)
			mono.android.TypeManager.Activate ("AppIntro.ScrollerCustomDuration, AppIntro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Views.Animations.IInterpolator, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public ScrollerCustomDuration (android.content.Context p0, android.view.animation.Interpolator p1, boolean p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == ScrollerCustomDuration.class)
			mono.android.TypeManager.Activate ("AppIntro.ScrollerCustomDuration, AppIntro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Views.Animations.IInterpolator, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Boolean, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void startScroll (int p0, int p1, int p2, int p3, int p4)
	{
		n_startScroll (p0, p1, p2, p3, p4);
	}

	private native void n_startScroll (int p0, int p1, int p2, int p3, int p4);

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
