package crc646acbd0515738a876;


public class NativeCookieHandler
	extends java.net.CookieManager
	implements
		mono.android.IGCUserPeer,
		okhttp3.CookieJar
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_loadForRequest:(Lokhttp3/HttpUrl;)Ljava/util/List;:GetLoadForRequest_Lokhttp3_HttpUrl_Handler:Square.OkHttp3.ICookieJarInvoker, Square.OkHttp3\n" +
			"n_saveFromResponse:(Lokhttp3/HttpUrl;Ljava/util/List;)V:GetSaveFromResponse_Lokhttp3_HttpUrl_Ljava_util_List_Handler:Square.OkHttp3.ICookieJarInvoker, Square.OkHttp3\n" +
			"";
		mono.android.Runtime.register ("ModernHttpClient.NativeCookieHandler, ModernHttpClient", NativeCookieHandler.class, __md_methods);
	}


	public NativeCookieHandler ()
	{
		super ();
		if (getClass () == NativeCookieHandler.class) {
			mono.android.TypeManager.Activate ("ModernHttpClient.NativeCookieHandler, ModernHttpClient", "", this, new java.lang.Object[] {  });
		}
	}


	public NativeCookieHandler (java.net.CookieStore p0, java.net.CookiePolicy p1)
	{
		super (p0, p1);
		if (getClass () == NativeCookieHandler.class) {
			mono.android.TypeManager.Activate ("ModernHttpClient.NativeCookieHandler, ModernHttpClient", "Java.Net.ICookieStore, Mono.Android:Java.Net.ICookiePolicy, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public java.util.List loadForRequest (okhttp3.HttpUrl p0)
	{
		return n_loadForRequest (p0);
	}

	private native java.util.List n_loadForRequest (okhttp3.HttpUrl p0);


	public void saveFromResponse (okhttp3.HttpUrl p0, java.util.List p1)
	{
		n_saveFromResponse (p0, p1);
	}

	private native void n_saveFromResponse (okhttp3.HttpUrl p0, java.util.List p1);

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
