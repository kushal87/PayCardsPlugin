package mono.cards.pay.paycardsrecognizer.sdk.ndk;


public class RecognitionStatusListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		cards.pay.paycardsrecognizer.sdk.ndk.RecognitionStatusListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCardImageReceived:(Landroid/graphics/Bitmap;)V:GetOnCardImageReceived_Landroid_graphics_Bitmap_Handler:Cards.Pay.Paycardsrecognizer.Sdk.Ndk.IRecognitionStatusListenerInvoker, PayCards.Droid\n" +
			"n_onRecognitionComplete:(Lcards/pay/paycardsrecognizer/sdk/ndk/RecognitionResult;)V:GetOnRecognitionComplete_Lcards_pay_paycardsrecognizer_sdk_ndk_RecognitionResult_Handler:Cards.Pay.Paycardsrecognizer.Sdk.Ndk.IRecognitionStatusListenerInvoker, PayCards.Droid\n" +
			"";
		mono.android.Runtime.register ("Cards.Pay.Paycardsrecognizer.Sdk.Ndk.IRecognitionStatusListenerImplementor, PayCards.Droid", RecognitionStatusListenerImplementor.class, __md_methods);
	}


	public RecognitionStatusListenerImplementor ()
	{
		super ();
		if (getClass () == RecognitionStatusListenerImplementor.class)
			mono.android.TypeManager.Activate ("Cards.Pay.Paycardsrecognizer.Sdk.Ndk.IRecognitionStatusListenerImplementor, PayCards.Droid", "", this, new java.lang.Object[] {  });
	}


	public void onCardImageReceived (android.graphics.Bitmap p0)
	{
		n_onCardImageReceived (p0);
	}

	private native void n_onCardImageReceived (android.graphics.Bitmap p0);


	public void onRecognitionComplete (cards.pay.paycardsrecognizer.sdk.ndk.RecognitionResult p0)
	{
		n_onRecognitionComplete (p0);
	}

	private native void n_onRecognitionComplete (cards.pay.paycardsrecognizer.sdk.ndk.RecognitionResult p0);

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
