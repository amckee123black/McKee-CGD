using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour 
{
	public GameObject selectedTarget;
	
	public int maxHealth;
	public int curHealth;
	
	public Vector3 screenPosition;
	
	public float healthBarLength;
	public float distance; //distance between enemies and player
	
	public GameObject target;
	
	public GUIStyle fullHealth;
	public GUIStyle emptyHealth;
	
	public bool displayHealthBar;
	
	
	
	
	void Awake() 
	{
		target = GameObject.FindGameObjectWithTag("Player");
		displayHealthBar = false;
	}
	void Start () 
	{
		healthBarLength = Screen.width / 20;
		
		selectedTarget = null;
	}
	void Update ()
	{
		distance = Vector3.Distance (target.transform.position, transform.position);
		Death();
		if(Input.GetKeyUp (KeyCode.V))
		{
			if(displayHealthBar == false)
				displayHealthBar = true;
			else if(displayHealthBar == true)
				displayHealthBar = false;
		}
	}
	void OnGUI()
	{
		screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		screenPosition.y = Screen.height - screenPosition.y;
		
		DisplayHealthBar();
	}
	public void AdjustCurrentHealth(int adj) 
	{
		curHealth += adj;
		
		//Ensures the curHealth cannot go below 0
		if(curHealth < 0)
			curHealth = 0;
		
		//Ensures curHealth can never be greater than maxHealth
		if(curHealth > maxHealth)
			curHealth = maxHealth;
		
		//Ensures no division by 0
		if(maxHealth < 1)
			maxHealth = 1;
		
		//full length of the bar multiplied by a percentage of how much health is currently there
		healthBarLength = (Screen.width / 20) * (curHealth / (float)maxHealth);
	}
	public void DisplayHealthBar() 
	{
		if(displayHealthBar == true)
		{
			if(distance <= 25)
			{	
				GUI.Box(new Rect(screenPosition.x-50, screenPosition.y-40, Screen.width / 20, 20), "", emptyHealth);
				GUI.Box(new Rect(screenPosition.x-50,screenPosition.y-40, healthBarLength, 20), curHealth + "/" + maxHealth, fullHealth);
			}
		}
		
	}
	public void Death()
	{
		if(curHealth == 0)
		{
			Destroy(gameObject);
		}
	}
}