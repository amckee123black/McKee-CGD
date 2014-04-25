using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
	public GameObject target; //creates an option to show what the player is targeting
	public float attackTimer = 0.0f;
	public float cooldownTimer = 2.0f;
	
	
	void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player");//targets the player as soon as they are in the Scene
		attackTimer = 0.0f;
	}
	void Update()
	{
		if(attackTimer == 0.0f)
		{	
			Attack(); //runs Attack(); function
			attackTimer = cooldownTimer;
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
		
		if(distance < 4.0f)
		{
			if(direction > 0)
			{	
				PlayerVitals pv = (PlayerVitals)target.GetComponent("PlayerVitals");
				pv.Health(-10);
			}
		}
	}
}