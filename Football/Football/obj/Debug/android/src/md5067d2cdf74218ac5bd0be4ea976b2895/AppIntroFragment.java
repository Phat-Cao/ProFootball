package md5067d2cdf74218ac5bd0be4ea976b2895;


public class AppIntroFragment
	extends md5067d2cdf74218ac5bd0be4ea976b2895.AppIntroBaseFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("AppIntro.AppIntroFragment, AppIntro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AppIntroFragment.class, __md_methods);
	}


	public AppIntroFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AppIntroFragment.class)
			mono.android.TypeManager.Activate ("AppIntro.AppIntroFragment, AppIntro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
