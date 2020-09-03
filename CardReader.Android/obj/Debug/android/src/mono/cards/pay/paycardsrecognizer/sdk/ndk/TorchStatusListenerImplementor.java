package mono.cards.pay.paycardsrecognizer.sdk.ndk;


public class TorchStatusListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		cards.pay.paycardsrecognizer.sdk.ndk.TorchStatusListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTorchStatusChanged:(Z)V:GetOnTorchStatusChanged_ZHandler:Cards.Pay.Paycardsrecognizer.Sdk.Ndk.ITorchStatusListenerInvoker, PayCards.Droid\n" +
			"";
		mono.android.Runtime.register ("Cards.Pay.Paycardsrecognizer.Sdk.Ndk.ITorchStatusListenerImplementor, PayCards.Droid", TorchStatusListenerImplementor.class, __md_methods);
	}


	public TorchStatusListenerImplementor ()
	{
		super ();
		if (getClass () == TorchStatusListenerImplementor.class)
			mono.android.TypeManager.Activate ("Cards.Pay.Paycardsrecognizer.Sdk.Ndk.ITorchStatusListenerImplementor, PayCards.Droid", "", this, new java.lang.Object[] {  });
	}


	public void onTorchStatusChanged (boolean p0)
	{
		n_onTorchStatusChanged (p0);
	}

	private native void n_onTorchStatusChanged (boolean p0);

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
