using UnityEngine;
using System.Collections;

public class ObjectInteract : MonoBehaviour {

	// Vars


	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.G))
		{
			Vector3 fwd = transform.TransformDirection(Vector3.forward);
			RaycastHit hit;
			Ray ray = new Ray(transform.position, fwd);


			if(Physics.Raycast(ray, out hit, 2))
			{
				if(hit.collider.gameObject.tag == "IntObj")
				{
					Debug.Log("IntObj hit");
					hit.collider.gameObject.GetComponent<InteractiveObjects>().interact();
				}
			}
		}
	}
}
