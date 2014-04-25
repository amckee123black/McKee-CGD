using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerTargeting : MonoBehaviour {
	
	
	
	public List<Transform> targets; //creates a new list named "targets"
	public Transform selectedTarget; //creates a Transform to show us who the "selectedTarget" is
	
	void Start ()
	{
		targets = new List<Transform>();//creates a list of all enemies when the script starts to ensure list is built
		AddAllEnemies();
		selectedTarget = null; //sets the start of selectTarget to "null" so player is not targeting anything on the start
	}
	void Update ()
	{
		if(Input.GetKeyDown (KeyCode.Tab))
		{
			TargetEnemy();
		}
		
		
	//	Debug.Log(eh.selectedTarget);
	}
	public void AddAllEnemies()
	{
		//creates an array name "go" of all available GameObjects in the Scene with the tag "Enemy"
		GameObject[] go = GameObject.FindGameObjectsWithTag("Enemy");
		
		//iterate through each object "enemy" in the array of "go"
		foreach(GameObject enemy in go)
			//send each iteration of "enemy" with their tranform to AddTarget();
			AddTarget(enemy.transform);
	}
	//creates a new function that takes an input "enemy" as a Transform
	public void AddTarget(Transform enemy)
	{
			//adds each instance of "enemy"
			targets.Add(enemy);
	}
	private void TargetEnemy()
	{
		if(selectedTarget == null) //makes sure if there is no "selectedTarget"
		{
			selectedTarget = targets[0]; //selects the first target on the list of available targets	
		}
		else
		{
			int index = targets.IndexOf(selectedTarget);//creates a numerical index of how many targets there are and where "selectedTarget" is in that Index
			if(index < targets.Count - 1) //if the index is less that the total count -1. Allows itteration through each target if there are more
			{
				index ++; //adds 1 each time		
			}
			else
			{
				index = 0; //if there is nothing else to target the index = 0
			}
			DeselectTarget();
			selectedTarget = targets[index];
		}
		SelectTarget();
	}
	private void SelectTarget()
	{
		PlayerAttack pa = (PlayerAttack)GetComponent("PlayerAttack");
		pa.target = selectedTarget.gameObject;
		
		EnemyHealth eh = (EnemyHealth)selectedTarget.GetComponent("EnemyHealth");
		eh.selectedTarget = selectedTarget.gameObject;
	}
	private void DeselectTarget()
	{
		selectedTarget = null;
	}
}