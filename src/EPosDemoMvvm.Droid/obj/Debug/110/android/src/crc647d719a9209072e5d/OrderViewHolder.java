package crc647d719a9209072e5d;


public class OrderViewHolder
	extends mvvmcross.droidx.recyclerview.MvxRecyclerViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EPosDemoMvvm.Droid.Views.Sale.OrderViewHolder, EPosDemoMvvm.Droid", OrderViewHolder.class, __md_methods);
	}


	public OrderViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == OrderViewHolder.class) {
			mono.android.TypeManager.Activate ("EPosDemoMvvm.Droid.Views.Sale.OrderViewHolder, EPosDemoMvvm.Droid", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
