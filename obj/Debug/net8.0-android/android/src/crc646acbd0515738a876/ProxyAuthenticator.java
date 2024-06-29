package crc646acbd0515738a876;


public class ProxyAuthenticator
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		okhttp3.Authenticator
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_authenticate:(Lokhttp3/Route;Lokhttp3/Response;)Lokhttp3/Request;:GetAuthenticate_Lokhttp3_Route_Lokhttp3_Response_Handler:Square.OkHttp3.IAuthenticatorInvoker, Square.OkHttp3\n" +
			"";
		mono.android.Runtime.register ("ModernHttpClient.ProxyAuthenticator, ModernHttpClient", ProxyAuthenticator.class, __md_methods);
	}


	public ProxyAuthenticator ()
	{
		super ();
		if (getClass () == ProxyAuthenticator.class) {
			mono.android.TypeManager.Activate ("ModernHttpClient.ProxyAuthenticator, ModernHttpClient", "", this, new java.lang.Object[] {  });
		}
	}

	public ProxyAuthenticator (java.lang.String p0, java.lang.String p1)
	{
		super ();
		if (getClass () == ProxyAuthenticator.class) {
			mono.android.TypeManager.Activate ("ModernHttpClient.ProxyAuthenticator, ModernHttpClient", "System.String, System.Private.CoreLib:System.String, System.Private.CoreLib", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public okhttp3.Request authenticate (okhttp3.Route p0, okhttp3.Response p1)
	{
		return n_authenticate (p0, p1);
	}

	private native okhttp3.Request n_authenticate (okhttp3.Route p0, okhttp3.Response p1);

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
