using System;
using UnityEngine;

// Token: 0x02000003 RID: 3
public class ExitInGame : MonoBehaviour
{
	// Token: 0x06000004 RID: 4 RVA: 0x000020C6 File Offset: 0x000002C6
	public void ExitPressed()
	{
		Application.Quit();
		Debug.Log("Exit pressed!");
	}
}
