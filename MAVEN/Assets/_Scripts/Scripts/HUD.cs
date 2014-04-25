using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
	
	}
	
	void Belt1()
	{
		var xPos = Screen.width / 2.5f;
		var yPos = Screen.height / 1.1f;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		
		GUI.Box (new Rect(xPos, yPos, width, height), "");
	}
	void Belt2()
	{
		var xPos = Screen.width / 2.5f;
		var yPos = Screen.height / 1.1f;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 100;
		
		GUI.Box (new Rect(xPos + width + xspacing, yPos, width, height), "");
	}
	void Belt3()
	{
		var xPos = Screen.width / 2.5f;
		var yPos = Screen.height / 1.1f;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 100;
		
		GUI.Box (new Rect(xPos + (width * 2) + (xspacing * 2), yPos, width, height), "");
	}
	void Belt4()
	{
		var xPos = Screen.width / 2.5f;
		var yPos = Screen.height / 1.1f;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 100;
		
		GUI.Box (new Rect(xPos + (width * 3) + (xspacing * 3), yPos, width, height), "");
	}
	void Vest1()
	{
		var xPos = Screen.width / 1.05f;
		var yPos = Screen.height / 3.5f;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		
		GUI.Box (new Rect(xPos, yPos, width, height), "");
	}
	void Vest2()
	{
		var xPos = Screen.width / 1.05f;
		var yPos = Screen.height / 3.5f;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var yspacing = Screen.height / 10;

		
		GUI.Box (new Rect(xPos, yPos + yspacing, width, height), "");
	}
	void Vest3()
	{
		var xPos = Screen.width / 1.05f;
		var yPos = Screen.height / 3.5f;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var yspacing = Screen.height / 10;

		GUI.Box (new Rect(xPos, yPos + (yspacing * 2), width, height), "");
	}
	void Vest4()
	{
		var xPos = Screen.width / 1.05f;
		var yPos = Screen.height / 3.5f;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var yspacing = Screen.height / 10;

		
		GUI.Box (new Rect(xPos, yPos + (yspacing * 3), width, height), "");
	}
	void Vest5()
	{
		var xPos = Screen.width / 1.05f;
		var yPos = Screen.height / 3.5f;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var yspacing = Screen.height / 10;

		
		GUI.Box (new Rect(xPos, yPos + (yspacing * 4), width, height), "");
	}
	void Weapon1()
	{
		var xPos = Screen.width / 100;
		var yPos = Screen.height / 8;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		
		GUI.Box (new Rect(xPos, yPos, width, height), "");
	}
	void Weapon2()
	{
		var xPos = Screen.width / 100;
		var yPos = Screen.height / 8;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 100;

		
		GUI.Box (new Rect(xPos + (width + xspacing), yPos, width, height), "");
	}
}
