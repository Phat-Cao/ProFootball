package md57abc7087afad6150249d2adf8ab4d3ca;


public class ChuyenNhuongActivity_LoadDataASync
	extends android.os.AsyncTask
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPreExecute:()V:GetOnPreExecuteHandler\n" +
			"n_doInBackground:([Ljava/lang/Object;)Ljava/lang/Object;:GetDoInBackground_arrayLjava_lang_Object_Handler\n" +
			"n_onPostExecute:(Ljava/lang/Object;)V:GetOnPostExecute_Ljava_lang_Object_Handler\n" +
			"";
		mono.android.Runtime.register ("Football.ChuyenNhuongActivity+LoadDataASync, Football, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ChuyenNhuongActivity_LoadDataASync.class, __md_methods);
	}


	public ChuyenNhuongActivity_LoadDataASync () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ChuyenNhuongActivity_LoadDataASync.class)
			mono.android.TypeManager.Activate ("Football.ChuyenNhuongActivity+LoadDataASync, Football, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public ChuyenNhuongActivity_LoadDataASync (md57abc7087afad6150249d2adf8ab4d3ca.ChuyenNhuongActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == ChuyenNhuongActivity_LoadDataASync.class)
			mono.android.TypeManager.Activate ("Football.ChuyenNhuongActivity+LoadDataASync, Football, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Football.ChuyenNhuongActivity, Football, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onPreExecute ()
	{
		n_onPreExecute ();
	}

	private native void n_onPreExecute ();


	public java.lang.Object doInBackground (java.lang.Object[] p0)
	{
		return n_doInBackground (p0);
	}

	private native java.lang.Object n_doInBackground (java.lang.Object[] p0);


	public void onPostExecute (java.lang.Object p0)
	{
		n_onPostExecute (p0);
	}

	private native void n_onPostExecute (java.lang.Object p0);

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