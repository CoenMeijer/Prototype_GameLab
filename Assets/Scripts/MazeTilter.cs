using UnityEngine;
using System.Collections;

public class MazeTilter : MonoBehaviour {

	private GameObject maze;
	private bool turning;
	private float startTime;

	public float turnTime;
	public Transform turnPoint;



	void Start()
	{
		maze = transform.GetChild(0).gameObject;
		transform.DetachChildren();
	}

	void Update()
	{
		if(!turning)
		{
			if(Input.GetButtonDown("GiantX"))
			{
				turning = true;
				StartCoroutine(rotateVar(new Vector3(90,0,0),Input.GetAxis("GiantX")));
			}
			else if(Input.GetButtonDown("GiantY"))
			{
				turning = true;
				StartCoroutine(rotateVar(new Vector3(0,90,0),Input.GetAxis("GiantY")));
			}
			else if(Input.GetButtonDown("GiantZ"))
			{
				turning = true;
				StartCoroutine(rotateVar(new Vector3(0,0,90),Input.GetAxis("GiantZ")));
			}
		}
	}

	IEnumerator rotateVar(Vector3 axis, float direct)
	{
		Debug.Log(axis + "   " + direct);
		int intDirect = (int)(direct/Mathf.Abs(direct));
		startTime = Time.time;
		int t = (int)turnTime*30;
		transform.position = turnPoint.position;
		maze.transform.parent = transform;

		for(int i=0; i<t;i++)
		{
			transform.Rotate((Vector3.Lerp(Vector3.zero,axis,(Time.time-startTime)/turnTime))*intDirect - transform.eulerAngles);
			yield return new WaitForSeconds(0.033f);

		}
		transform.eulerAngles = axis*intDirect;
		transform.DetachChildren();
		transform.Rotate(transform.rotation.eulerAngles*-1);
		turning = false;
	}

}
