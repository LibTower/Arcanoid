using System;
using UnityEngine;

// Token: 0x02000002 RID: 2
public class DublicateOfPrefabs : MonoBehaviour
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
	public void Dubl()
	{
		for (float num = 4f; num > 1f; num -= 0.5f)
		{
			for (float num2 = -2f; num2 < 2f; num2 += 1.1f)
			{
				UnityEngine.Object.Instantiate<Transform>(this.brick, new Vector2(num2, num), Quaternion.identity);
			}
		}
	}

	// Token: 0x04000001 RID: 1
	public Transform brick;
}
