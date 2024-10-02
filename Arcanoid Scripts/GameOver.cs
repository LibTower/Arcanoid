using System;
using UnityEngine;

// Token: 0x02000004 RID: 4
public class GameOver : MonoBehaviour
{
	// Token: 0x06000006 RID: 6 RVA: 0x000020DF File Offset: 0x000002DF
	private void Start()
	{
		this.Paused = true;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000020E8 File Offset: 0x000002E8
	private void Update()
	{
		if (this.Paused)
		{
			Time.timeScale = 0f;
			if (this.key)
			{
				this.Paused = !this.Paused;
			}
		}
		else
		{
			Time.timeScale = 1f;
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			this.key = true;
		}
		if (this.ball.GetComponent<Transform>().position.y < -2.5f)
		{
			this.ball.GetComponent<Transform>().position = new Vector2(-1f, 0.5f);
			this.panel.GetComponent<Transform>().position = new Vector2(0f, -2.5f);
			this.ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
			this.Paused = !this.Paused;
			this.key = false;
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000021E5 File Offset: 0x000003E5
	public void Resume()
	{
		this.Paused = false;
		this.key = false;
	}

	// Token: 0x04000002 RID: 2
	public GameObject panel;

	// Token: 0x04000003 RID: 3
	public GameObject ball;

	// Token: 0x04000004 RID: 4
	private bool Paused;

	// Token: 0x04000005 RID: 5
	private bool key;
}
