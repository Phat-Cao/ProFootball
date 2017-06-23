package md57abc7087afad6150249d2adf8ab4d3ca;


public class PhapActivity
	extends android.support.v4.app.FragmentActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Football.PhapActivity, Football, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PhapActivity.class, __md_methods);
	}


	public PhapActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PhapActivity.class)
			mono.android.TypeManager.Activate ("Football.PhapActivity, Football, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
