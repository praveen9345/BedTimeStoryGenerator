package crc646acbd0515738a876;


public class CertificatePinner
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ModernHttpClient.CertificatePinner, ModernHttpClient", CertificatePinner.class, __md_methods);
	}


	public CertificatePinner ()
	{
		super ();
		if (getClass () == CertificatePinner.class) {
			mono.android.TypeManager.Activate ("ModernHttpClient.CertificatePinner, ModernHttpClient", "", this, new java.lang.Object[] {  });
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
