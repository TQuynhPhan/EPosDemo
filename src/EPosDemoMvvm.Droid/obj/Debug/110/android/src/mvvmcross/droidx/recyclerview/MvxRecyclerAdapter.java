package mvvmcross.droidx.recyclerview;


public class MvxRecyclerAdapter
	extends androidx.recyclerview.widget.RecyclerView.Adapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onViewAttachedToWindow:(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V:GetOnViewAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler\n" +
			"n_onViewDetachedFromWindow:(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V:GetOnViewDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler\n" +
			"n_getItemViewType:(I)I:GetGetItemViewType_IHandler\n" +
			"n_onCreateViewHolder:(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;:GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler\n" +
			"n_onBindViewHolder:(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V:GetOnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler\n" +
			"n_onViewRecycled:(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V:GetOnViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler\n" +
			"n_onDetachedFromRecyclerView:(Landroidx/recyclerview/widget/RecyclerView;)V:GetOnDetachedFromRecyclerView_Landroidx_recyclerview_widget_RecyclerView_Handler\n" +
			"n_onFailedToRecycleView:(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Z:GetOnFailedToRecycleView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler\n" +
			"n_getItemCount:()I:GetGetItemCountHandler\n" +
			"";
		mono.android.Runtime.register ("MvvmCross.DroidX.RecyclerView.MvxRecyclerAdapter, MvvmCross.DroidX.RecyclerView", MvxRecyclerAdapter.class, __md_methods);
	}


	public MvxRecyclerAdapter ()
	{
		super ();
		if (getClass () == MvxRecyclerAdapter.class) {
			mono.android.TypeManager.Activate ("MvvmCross.DroidX.RecyclerView.MvxRecyclerAdapter, MvvmCross.DroidX.RecyclerView", "", this, new java.lang.Object[] {  });
		}
	}


	public void onViewAttachedToWindow (androidx.recyclerview.widget.RecyclerView.ViewHolder p0)
	{
		n_onViewAttachedToWindow (p0);
	}

	private native void n_onViewAttachedToWindow (androidx.recyclerview.widget.RecyclerView.ViewHolder p0);


	public void onViewDetachedFromWindow (androidx.recyclerview.widget.RecyclerView.ViewHolder p0)
	{
		n_onViewDetachedFromWindow (p0);
	}

	private native void n_onViewDetachedFromWindow (androidx.recyclerview.widget.RecyclerView.ViewHolder p0);


	public int getItemViewType (int p0)
	{
		return n_getItemViewType (p0);
	}

	private native int n_getItemViewType (int p0);


	public androidx.recyclerview.widget.RecyclerView.ViewHolder onCreateViewHolder (android.view.ViewGroup p0, int p1)
	{
		return n_onCreateViewHolder (p0, p1);
	}

	private native androidx.recyclerview.widget.RecyclerView.ViewHolder n_onCreateViewHolder (android.view.ViewGroup p0, int p1);


	public void onBindViewHolder (androidx.recyclerview.widget.RecyclerView.ViewHolder p0, int p1)
	{
		n_onBindViewHolder (p0, p1);
	}

	private native void n_onBindViewHolder (androidx.recyclerview.widget.RecyclerView.ViewHolder p0, int p1);


	public void onViewRecycled (androidx.recyclerview.widget.RecyclerView.ViewHolder p0)
	{
		n_onViewRecycled (p0);
	}

	private native void n_onViewRecycled (androidx.recyclerview.widget.RecyclerView.ViewHolder p0);


	public void onDetachedFromRecyclerView (androidx.recyclerview.widget.RecyclerView p0)
	{
		n_onDetachedFromRecyclerView (p0);
	}

	private native void n_onDetachedFromRecyclerView (androidx.recyclerview.widget.RecyclerView p0);


	public boolean onFailedToRecycleView (androidx.recyclerview.widget.RecyclerView.ViewHolder p0)
	{
		return n_onFailedToRecycleView (p0);
	}

	private native boolean n_onFailedToRecycleView (androidx.recyclerview.widget.RecyclerView.ViewHolder p0);


	public int getItemCount ()
	{
		return n_getItemCount ();
	}

	private native int n_getItemCount ();

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
