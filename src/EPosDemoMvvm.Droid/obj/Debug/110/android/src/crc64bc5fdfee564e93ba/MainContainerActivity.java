package crc64bc5fdfee564e93ba;


public class MainContainerActivity
	extends crc644d4891ea00c0db6f.BaseActivity_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EPosDemoMvvm.Droid.Views.Main.MainContainerActivity, EPosDemoMvvm.Droid", MainContainerActivity.class, __md_methods);
	}


	public MainContainerActivity ()
	{
		super ();
		if (getClass () == MainContainerActivity.class) {
			mono.android.TypeManager.Activate ("EPosDemoMvvm.Droid.Views.Main.MainContainerActivity, EPosDemoMvvm.Droid", "", this, new java.lang.Object[] {  });
		}
	}


	public MainContainerActivity (int p0)
	{
		super (p0);
		if (getClass () == MainContainerActivity.class) {
			mono.android.TypeManager.Activate ("EPosDemoMvvm.Droid.Views.Main.MainContainerActivity, EPosDemoMvvm.Droid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
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
