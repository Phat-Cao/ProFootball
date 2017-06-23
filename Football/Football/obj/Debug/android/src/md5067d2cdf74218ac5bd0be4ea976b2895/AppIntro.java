package md5067d2cdf74218ac5bd0be4ea976b2895;


public abstract class AppIntro
	extends md5067d2cdf74218ac5bd0be4ea976b2895.AppIntroBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("AppIntro.AppIntro, AppIntro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AppIntro.class, __md_methods);
	}


	public AppIntro () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AppIntro.class)
			mono.android.TypeManager.Activate ("AppIntro.AppIntro, AppIntro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
