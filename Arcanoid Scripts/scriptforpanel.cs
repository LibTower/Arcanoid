using System;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class scriptforpanel : MonoBehaviour
{
	// Token: 0x06000018 RID: 24 RVA: 0x0000253F File Offset: 0x0000073F
	private void Start()
	{
		this.rg = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002550 File Offset: 0x00000750
	private void Update()
	{
		if (Input.GetAxis("Horizontal") > 0f)
		{
			this.rg.velocity = new Vector2(this.speed_player, this.rg.velocity.y);
		}
		else if (Input.GetAxis("Horizontal") < 0f)
		{
			this.rg.velocity = new Vector2(-this.speed_player, this.rg.velocity.y);
		}
		else
		{
			this.rg.velocity = new Vector2(0f, this.rg.velocity.y);
		}
		if (this.ball.GetComponent<Transform>().position.y < -2.5f)
		{
			this.rg.velocity = new Vector2(0f, 0f);
		}
	}

	// Token: 0x0400000D RID: 13
	public GameObject ball;

	// Token: 0x0400000E RID: 14
	private Rigidbody2D rg;

	// Token: 0x0400000F RID: 15
	public float speed_player;
}
