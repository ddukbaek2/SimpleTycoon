using UnityEngine;


/// <summary>
/// 런타임 이니셜라이저.
/// </summary>
public static class RuntimeInitializer
{
	[RuntimeInitializeOnLoadMethod]
	public static void Initialize()
	{
		Debug.Log("[SimpleTycoon] Initialize()");
	}
}