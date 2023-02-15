package crc647d719a9209072e5d;


public class ProductAdapter
	extends mvvmcross.droidx.recyclerview.MvxRecyclerAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateViewHolder:(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;:GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler\n" +
			"";
		mono.android.Runtime.register ("EPosDemoMvvm.Droid.Views.Sale.ProductAdapter, EPosDemoMvvm.Droid", ProductAdapter.class, __md_methods);
	}


	public ProductAdapter ()
	{
		super ();
		if (getClass () == ProductAdapter.class) {
			mono.android.TypeManager.Activate ("EPosDemoMvvm.Droid.Views.Sale.ProductAdapter, EPosDemoMvvm.Droid", "", this, new java.lang.Object[] {  });
		}
	}


	public androidx.recyclerview.widget.RecyclerView.ViewHolder onCreateViewHolder (android.view.ViewGroup p0, int p1)
	{
		return n_onCreateViewHolder (p0, p1);
	}

	private native androidx.recyclerview.widget.RecyclerView.ViewHolder n_onCreateViewHolder (android.view.ViewGroup p0, int p1);

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
