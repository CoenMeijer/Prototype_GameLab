using UnityEngine;
using System.Collections;

public class SpawnpointZone : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == TagsStatics.playerTag)
		{
			col.gameObject.GetComponent<PlayerDeathRespawn>().newSpawnPoint(transform);
		}
	}
}
