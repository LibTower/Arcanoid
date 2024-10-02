using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000008 RID: 8
public class prefabscript2 : MonoBehaviour
{
	// Token: 0x06000014 RID: 20 RVA: 0x00002308 File Offset: 0x00000508
	private void Start()
	{
		this.MyLifes.GetComponent<Text>().text = Convert.ToString(5 - this.life);
		for (float num = 4f; num > 1f; num -= 0.5f)
		{
			for (float num2 = -2f; num2 < 2f; num2 += 1.1f)
			{
				UnityEngine.Object.Instantiate<Transform>(this.brick, new Vector2(num2, num), Quaternion.identity);
			}
		}
		this.life = 0;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002394 File Offset: 0x00000594
	public void Update()
	{
		if (this.ball.GetComponent<Transform>().position.y < -2.5f)
		{
			base.StartCoroutine(this.Wait());
			this.life++;
			this.MyLifes.GetComponent<Text>().text = Convert.ToString(5 - this.life);
			Debug.Log("счетчик " + this.life);
		}
		if (this.life >= 5)
		{
			base.StartCoroutine(this.Wait());
			GameObject.Find("Main Camera").GetComponent<DublicateOfPrefabs>().Dubl();
			this.life = 0;
			Debug.Log("счетчик " + this.life);
			GameObject.Find("point").GetComponent<Points>().ScoreEqually(0);
			this.MyLifes.GetComponent<Text>().text = Convert.ToString(5 - this.life);
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002498 File Offset: 0x00000698
	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(100f);
		yield break;
	}

	// Token: 0x04000009 RID: 9
	private int life;

	// Token: 0x0400000A RID: 10
	public Transform brick;

	// Token: 0x0400000B RID: 11
	public GameObject ball;

	// Token: 0x0400000C RID: 12
	public GameObject MyLifes;
}
