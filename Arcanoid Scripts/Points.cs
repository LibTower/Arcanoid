using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000006 RID: 6
public class Points : MonoBehaviour
{
	// Token: 0x0600000D RID: 13 RVA: 0x0000222C File Offset: 0x0000042C
	private void Start()
	{
		this.Score = 0;
		this.myScore.GetComponent<Text>().text = Convert.ToString(this.Score);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002250 File Offset: 0x00000450
	public void ScorePlus(int x)
	{
		this.Score += x;
		this.myScore.GetComponent<Text>().text = Convert.ToString(this.Score);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x0000227B File Offset: 0x0000047B
	public void ScoreEqually(int y)
	{
		this.Score = y;
		this.myScore.GetComponent<Text>().text = Convert.ToString(this.Score);
	}

	// Token: 0x04000006 RID: 6
	public GameObject myScore;

	// Token: 0x04000007 RID: 7
	public int Score;
}
