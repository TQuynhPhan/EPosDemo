package crc64bc5fdfee564e93ba;


public class MainFragment
	extends crc644d4891ea00c0db6f.BaseFragment_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EPosDemoMvvm.Droid.Views.Main.MainFragment, EPosDemoMvvm.Droid", MainFragment.class, __md_methods);
	}


	public MainFragment ()
	{
		super ();
		if (getClass () == MainFragment.class) {
			mono.android.TypeManager.Activate ("EPosDemoMvvm.Droid.Views.Main.MainFragment, EPosDemoMvvm.Droid", "", this, new java.lang.Object[] {  });
		}
	}


	public MainFragment (int p0)
	{
		super (p0);
		if (getClass () == MainFragment.class) {
			mono.android.TypeManager.Activate ("EPosDemoMvvm.Droid.Views.Main.MainFragment, EPosDemoMvvm.Droid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
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
