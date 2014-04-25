using UnityEngine;
using System.Collections;

public class PlayerVitals : MonoBehaviour {
	
	
	float sprintTimer = 5.0f;
	float sprintTimerReset = 5.0f;
	float rechargeTimerMax = 0.5f;
	
	public int curStamina = 100;
	public int maxStamina = 100;
	public int maxAttunement = 100;
	public int curAttunement = 100;
	public int maxHealth = 100;
	public int curHealth = 100;
	
	public GUIStyle emptyStamina;
	public GUIStyle fullStamina;
	public GUIStyle emptyAttunement;
	public GUIStyle fullAttunement;
	public GUIStyle emptyHealth;
	public GUIStyle fullHealth;
	

	float staminaBarLength;
	float attunementBarLength;
	float healthBarLength;
	
	

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
//		Stamina();
		Run();
		if(rechargeTimerMax <= 0)
		{
			curStamina += 1;
			if(curStamina > maxStamina)
			{
				curStamina = maxStamina;
			}
			rechargeTimerMax = 0.5f;
		}
		
		healthBarLength = (Screen.width / 9) * (curHealth / (float)maxHealth);
		staminaBarLength = (Screen.width / 9) * (curStamina / (float)maxStamina);
		attunementBarLength = (Screen.width / 9) * (curAttunement / (float)maxAttunement);		
	}
	void OnGUI ()
	{
		DrawStamina();
		DrawAttunement();
		DrawHealth();
	}
	
	public void Stamina(int adj)
	{
		curStamina += adj;
		
		if(curStamina < 0)
		{
			curStamina = 0;
		}
		if(curStamina > maxStamina)
		{
			curStamina = maxStamina;
		}
		if(maxStamina < 1)
		{
			maxStamina = 1;
		}
	}
	private void DrawStamina()
	{
		var xPos = Screen.width / 100;
		var yPos = Screen.height / 20;
		
		GUI.Box(new Rect(xPos, yPos, (Screen.width / 9), 20), "",  emptyStamina);
		GUI.Box(new Rect(xPos, yPos, staminaBarLength, 20), curStamina + "/" + maxStamina, fullStamina);
	}
	public void Attunement(int adj)
	{
		curAttunement += adj;
		
		if(curAttunement < 0)
			curAttunement = 0;
		
		if(curAttunement > maxAttunement)
			curAttunement = maxAttunement;
		
		if(maxAttunement < 1)
			maxAttunement = 1;
	}
	private void DrawAttunement()
	{
		var xPos = Screen.width / 100;
		var yPos = Screen.height / 12;
		
		GUI.Box(new Rect(xPos, yPos, (Screen.width / 9), 20), "", emptyAttunement);
		GUI.Box(new Rect(xPos, yPos, attunementBarLength, 20), curAttunement + "/" + maxAttunement, fullAttunement);
	}
	public void Run()
	{
		if(Input.GetKey (KeyCode.LeftShift))
		{
			rechargeTimerMax = 0.5f;
			if(curStamina> 0)
			{
				curStamina -= 1;
			}
		}
		else if(curStamina < maxStamina)
			rechargeTimerMax -= Time.deltaTime;
			
		if(sprintTimer < 0)
			sprintTimer = sprintTimerReset;
		
	}
	public void Health(int adj)
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
		
	}
	private void DrawHealth()
	{
		var xPos = Screen.width / 100;
		var yPos = Screen.height / 60;
		
		GUI.Box(new Rect(xPos, yPos, (Screen.width / 9), 20), "", emptyHealth);
		GUI.Box(new Rect(xPos, yPos, healthBarLength, 20), curHealth + "/" + maxHealth, fullHealth);
	}
	
}
