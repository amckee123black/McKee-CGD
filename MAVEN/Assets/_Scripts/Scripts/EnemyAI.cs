using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	
	private Transform myTransform;
	
	public Transform target;
	
	public int moveSpeed;
	public int rotationSpeed;
	
	public float maxDistance = 3.5f;
	
	//Vector3 dir = (target.transform.position - Transform.position).normalized;


	// Use this for initialization
	void Start () 
	{
		myTransform = transform;
		GameObject go = GameObject.FindGameObjectWithTag("Player");
		
		target = go.transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		float distance = Vector3.Distance (target.transform.position, transform.position); //determines the distance between target and self
		
		
		if(distance < 30)
		{	
			//rotate to look at the player
			myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
		
			//move towards the player
			if(Vector3.Distance (target.position, myTransform.position) > maxDistance)
			{	
			myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
			}
		}
	}

}
