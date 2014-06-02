using UnityEngine;
using System.Collections;

public class KeyLock : InteractiveObjects {

	protected override void effect()
	{
		GameObject key = GameObject.FindWithTag(TagsStatics.playerTag).GetComponent<Keyholder>().takeOuKey();

		if(key != null)
		{
			key.GetComponent<KeyPickup>().turnOnOff(true);
			key.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		}
		else{
			Debug.Log("No key");
		}
	}
}
