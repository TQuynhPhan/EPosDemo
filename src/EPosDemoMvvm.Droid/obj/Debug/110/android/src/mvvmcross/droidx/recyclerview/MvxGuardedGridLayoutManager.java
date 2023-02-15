package mvvmcross.droidx.recyclerview;


public class MvxGuardedGridLayoutManager
	extends androidx.recyclerview.widget.GridLayoutManager
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_supportsPredictiveItemAnimations:()Z:GetSupportsPredictiveItemAnimationsHandler\n" +
			"n_onLayoutChildren:(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)V:GetOnLayoutChildren_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler\n" +
			"";
		mono.android.Runtime.register ("MvvmCross.DroidX.RecyclerView.MvxGuardedGridLayoutManager, MvvmCross.DroidX.RecyclerView", MvxGuardedGridLayoutManager.class, __md_methods);
	}


	public MvxGuardedGridLayoutManager (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == MvxGuardedGridLayoutManager.class) {
			mono.android.TypeManager.Activate ("MvvmCross.DroidX.RecyclerView.MvxGuardedGridLayoutManager, MvvmCross.DroidX.RecyclerView", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public MvxGuardedGridLayoutManager (android.content.Context p0, int p1)
	{
		super (p0, p1);
		if (getClass () == MvxGuardedGridLayoutManager.class) {
			mono.android.TypeManager.Activate ("MvvmCross.DroidX.RecyclerView.MvxGuardedGridLayoutManager, MvvmCross.DroidX.RecyclerView", "Android.Content.Context, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public MvxGuardedGridLayoutManager (android.content.Context p0, int p1, int p2, boolean p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == MvxGuardedGridLayoutManager.class) {
			mono.android.TypeManager.Activate ("MvvmCross.DroidX.RecyclerView.MvxGuardedGridLayoutManager, MvvmCross.DroidX.RecyclerView", "Android.Content.Context, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib:System.Boolean, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public boolean supportsPredictiveItemAnimations ()
	{
		return n_supportsPredictiveItemAnimations ();
	}

	private native boolean n_supportsPredictiveItemAnimations ();


	public void onLayoutChildren (androidx.recyclerview.widget.RecyclerView.Recycler p0, androidx.recyclerview.widget.RecyclerView.State p1)
	{
		n_onLayoutChildren (p0, p1);
	}

	private native void n_onLayoutChildren (androidx.recyclerview.widget.RecyclerView.Recycler p0, androidx.recyclerview.widget.RecyclerView.State p1);

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
