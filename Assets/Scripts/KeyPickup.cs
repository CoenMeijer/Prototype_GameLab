using UnityEngine;
using System.Collections;

public class KeyPickup : InteractiveObjects {


	protected override void effect()
	{
		GameObject.FindWithTag(TagsStatics.playerTag).GetComponent<Keyholder>().addKey(gameObject);
		turnOnOff(false);
	}

	public void turnOnOff(bool OnOff)
	{
		collider.enabled = OnOff;
		renderer.enabled = OnOff;
	}
}
