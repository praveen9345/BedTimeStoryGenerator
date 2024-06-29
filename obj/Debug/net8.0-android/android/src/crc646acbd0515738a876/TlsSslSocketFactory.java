package crc646acbd0515738a876;


public class TlsSslSocketFactory
	extends javax.net.ssl.SSLSocketFactory
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getDefaultCipherSuites:()[Ljava/lang/String;:GetGetDefaultCipherSuitesHandler\n" +
			"n_getSupportedCipherSuites:()[Ljava/lang/String;:GetGetSupportedCipherSuitesHandler\n" +
			"n_createSocket:(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;:GetCreateSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_IHandler\n" +
			"n_createSocket:(Ljava/net/InetAddress;I)Ljava/net/Socket;:GetCreateSocket_Ljava_net_InetAddress_IHandler\n" +
			"n_createSocket:(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;:GetCreateSocket_Ljava_lang_String_ILjava_net_InetAddress_IHandler\n" +
			"n_createSocket:(Ljava/lang/String;I)Ljava/net/Socket;:GetCreateSocket_Ljava_lang_String_IHandler\n" +
			"n_createSocket:(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;:GetCreateSocket_Ljava_net_Socket_Ljava_lang_String_IZHandler\n" +
			"n_createSocket:()Ljava/net/Socket;:GetCreateSocketHandler\n" +
			"";
		mono.android.Runtime.register ("ModernHttpClient.TlsSslSocketFactory, ModernHttpClient", TlsSslSocketFactory.class, __md_methods);
	}


	public TlsSslSocketFactory ()
	{
		super ();
		if (getClass () == TlsSslSocketFactory.class) {
			mono.android.TypeManager.Activate ("ModernHttpClient.TlsSslSocketFactory, ModernHttpClient", "", this, new java.lang.Object[] {  });
		}
	}

	public TlsSslSocketFactory (javax.net.ssl.KeyManager[] p0, javax.net.ssl.TrustManager[] p1)
	{
		super ();
		if (getClass () == TlsSslSocketFactory.class) {
			mono.android.TypeManager.Activate ("ModernHttpClient.TlsSslSocketFactory, ModernHttpClient", "Javax.Net.Ssl.IKeyManager[], Mono.Android:Javax.Net.Ssl.ITrustManager[], Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public java.lang.String[] getDefaultCipherSuites ()
	{
		return n_getDefaultCipherSuites ();
	}

	private native java.lang.String[] n_getDefaultCipherSuites ();


	public java.lang.String[] getSupportedCipherSuites ()
	{
		return n_getSupportedCipherSuites ();
	}

	private native java.lang.String[] n_getSupportedCipherSuites ();


	public java.net.Socket createSocket (java.net.InetAddress p0, int p1, java.net.InetAddress p2, int p3)
	{
		return n_createSocket (p0, p1, p2, p3);
	}

	private native java.net.Socket n_createSocket (java.net.InetAddress p0, int p1, java.net.InetAddress p2, int p3);


	public java.net.Socket createSocket (java.net.InetAddress p0, int p1)
	{
		return n_createSocket (p0, p1);
	}

	private native java.net.Socket n_createSocket (java.net.InetAddress p0, int p1);


	public java.net.Socket createSocket (java.lang.String p0, int p1, java.net.InetAddress p2, int p3)
	{
		return n_createSocket (p0, p1, p2, p3);
	}

	private native java.net.Socket n_createSocket (java.lang.String p0, int p1, java.net.InetAddress p2, int p3);


	public java.net.Socket createSocket (java.lang.String p0, int p1)
	{
		return n_createSocket (p0, p1);
	}

	private native java.net.Socket n_createSocket (java.lang.String p0, int p1);


	public java.net.Socket createSocket (java.net.Socket p0, java.lang.String p1, int p2, boolean p3)
	{
		return n_createSocket (p0, p1, p2, p3);
	}

	private native java.net.Socket n_createSocket (java.net.Socket p0, java.lang.String p1, int p2, boolean p3);


	public java.net.Socket createSocket ()
	{
		return n_createSocket ();
	}

	private native java.net.Socket n_createSocket ();

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
