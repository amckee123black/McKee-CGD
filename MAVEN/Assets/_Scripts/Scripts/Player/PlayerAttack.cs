using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
	public GameObject target; //creates an option to show what the player is targeting
	public float attackTimer = 0.0f;
	public float cooldownTimer = 2.0f;
	
//	private Transform myTransform;
	
	void Start()
	{	
//		myTransform = transform;
		attackTimer = 0.0f;
		target = null;
	}
	void Update()
	{
		if(Input.GetMouseButtonUp(0)) //checks to see if left mouse button was clicked
		{		
			if(attackTimer == 0.0f)
			{	
			Attack(); //runs Attack(); function
			attackTimer = cooldownTimer;
			}
		}
		attackTimer -= Time.deltaTime;
		if(attackTimer < 0.0f)
		{
			attackTimer = 0.0f;
		}
	
		
	}
	private void Attack()
	{
		float distance = Vector3.Distance (target.transform.position, transform.position); //determines the distance between target and self
		
		Vector3 dir = (target.transform.position - transform.position).normalized;
		
		float direction = Vector3.Dot (dir, transform.forward);
		
		if(distance < 4)
		{
			if(direction > 0)
			{	
				EnemyHealth eh = (EnemyHealth)target.GetComponent("EnemyHealth");
				eh.AdjustCurrentHealth(-10);
			}
		}
		}
}