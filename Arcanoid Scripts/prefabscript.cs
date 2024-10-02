using System;
using UnityEngine;

// Token: 0x02000007 RID: 7
public class prefabscript : MonoBehaviour
{
	// Token: 0x06000011 RID: 17 RVA: 0x000022A7 File Offset: 0x000004A7
	private void Start()
	{
		this.blockCounter = 0;
		Debug.Log(this.blockCounter);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000022C0 File Offset: 0x000004C0
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Ball")
		{
			GameObject.Find("point").GetComponent<Points>().ScorePlus(50);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x04000008 RID: 8
	public int blockCounter;
}
