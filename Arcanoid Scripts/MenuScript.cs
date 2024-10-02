using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000005 RID: 5
public class MenuScript : MonoBehaviour
{
	// Token: 0x0600000A RID: 10 RVA: 0x000021FD File Offset: 0x000003FD
	public void PlayPressed()
	{
		SceneManager.LoadScene("arcanoide");
		Debug.Log("play pressed!");
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002213 File Offset: 0x00000413
	public void ExitPressed()
	{
		Application.Quit();
		Debug.Log("Exit pressed!");
	}
}
