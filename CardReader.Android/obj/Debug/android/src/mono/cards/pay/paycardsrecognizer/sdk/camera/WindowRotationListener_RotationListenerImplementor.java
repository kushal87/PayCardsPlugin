package mono.cards.pay.paycardsrecognizer.sdk.camera;


public class WindowRotationListener_RotationListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		cards.pay.paycardsrecognizer.sdk.camera.WindowRotationListener.RotationListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onWindowRotationChanged:()V:GetOnWindowRotationChangedHandler:Cards.Pay.Paycardsrecognizer.Sdk.Camera.WindowRotationListener/IRotationListenerInvoker, PayCards.Droid\n" +
			"";
		mono.android.Runtime.register ("Cards.Pay.Paycardsrecognizer.Sdk.Camera.WindowRotationListener+IRotationListenerImplementor, PayCards.Droid", WindowRotationListener_RotationListenerImplementor.class, __md_methods);
	}


	public WindowRotationListener_RotationListenerImplementor ()
	{
		super ();
		if (getClass () == WindowRotationListener_RotationListenerImplementor.class)
			mono.android.TypeManager.Activate ("Cards.Pay.Paycardsrecognizer.Sdk.Camera.WindowRotationListener+IRotationListenerImplementor, PayCards.Droid", "", this, new java.lang.Object[] {  });
	}


	public void onWindowRotationChanged ()
	{
		n_onWindowRotationChanged ();
	}

	private native void n_onWindowRotationChanged ();

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
