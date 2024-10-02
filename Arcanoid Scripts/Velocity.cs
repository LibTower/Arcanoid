using System;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class Velocity : MonoBehaviour
{
	// Token: 0x0600001B RID: 27 RVA: 0x00002650 File Offset: 0x00000850
	private void Update()
	{
		if (this.Ball.GetComponent<Rigidbody2D>().angularVelocity > 100f || this.Ball.GetComponent<Rigidbody2D>().angularVelocity < 1f)
		{
			this.Ball.GetComponent<Rigidbody2D>().angularVelocity = 1f;
		}
		if (this.Ball.GetComponent<Rigidbody2D>().velocity.x > 13f)
		{
			this.Ball.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, this.Ball.GetComponent<Rigidbody2D>().velocity.y);
		}
		if (this.Ball.GetComponent<Rigidbody2D>().velocity.x < -13f)
		{
			this.Ball.GetComponent<Rigidbody2D>().velocity = new Vector2(-10f, this.Ball.GetComponent<Rigidbody2D>().velocity.y);
		}
		if (this.Ball.GetComponent<Rigidbody2D>().velocity.y > 13f)
		{
			this.Ball.GetComponent<Rigidbody2D>().velocity = new Vector2(this.Ball.GetComponent<Rigidbody2D>().velocity.x, 10f);
		}
		if (this.Ball.GetComponent<Rigidbody2D>().velocity.y < -13f)
		{
			this.Ball.GetComponent<Rigidbody2D>().velocity = new Vector2(this.Ball.GetComponent<Rigidbody2D>().velocity.x, -10f);
		}
	}

	// Token: 0x04000010 RID: 16
	public GameObject Ball;
}
