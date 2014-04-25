using UnityEngine;
using System.Collections;

public class DragDrop : MonoBehaviour {
	
	public Texture2D curSlotTexture;
	public string curSlot;
	public bool slotStatus;
	public Texture2D holdTexture;
	public string holdSlot;
	
	public int slotCheck;
	
	public GameObject inventory;
	public GameObject equip;
	
	public GUIStyle mouseDrawStyle;
	
	private int mousereleasestatus;
	
	Texture2D emptyInv;
	
	// Use this for initialization
	void Start () 
	{
		mouseDrawStyle.normal.background = null;
		
		inventory = GameObject.FindGameObjectWithTag("Inventory");
		
		emptyInv = Resources.Load("Textures/Inventory/EmptyInv", typeof(Texture2D)) as Texture2D;
	}
	
	// Update is called once per frame
	void OnGUI()
	{
		DrawMouseHold();
	}
	void Update () 
	{
		
		MouseStatus();

		
	}

	public void DrawMouseHold()
	{
		GUI.depth = 0;
		Event e = Event.current;
		GUI.Box (new Rect(e.mousePosition.x, e.mousePosition.y, Screen.width / 24, Screen.height / 12), "", mouseDrawStyle);
	}
	private void MouseStatus ()
	{
	//	Inventory i = (Inventory)inventory.GetComponent("Inventory");
		
		if(Input.GetMouseButton(0) == true)
		{
			if(mouseDrawStyle.normal.background == null && curSlotTexture != emptyInv)
			{
				mouseDrawStyle.normal.background = curSlotTexture;
				holdSlot = curSlot;
				if(curSlot != "bagSize")
				{
					EmptySlot();
				}
				
			}
		}
		if(Input.GetMouseButton(0) == false && slotCheck == 1)
		{
			if(mouseDrawStyle.normal.background != null)
			{
				if(slotStatus == true)
				{
					MoveCheck();
					mouseDrawStyle.normal.background = null;
				}
				if(slotStatus == false)
				{
					holdTexture = curSlotTexture;
					SlotCheck();
					MoveCheck();
					mouseDrawStyle.normal.background = null;
				}
				
			}
		}
		if(Input.GetMouseButton(0) == false && slotCheck == 0)
		{
		
		}
	}

	
	
	public void SlotCheck()
	{
		Inventory i = (Inventory)inventory.GetComponent("Inventory");
		
		if(holdSlot == "invSlot1")
		{
			i.invSlot1.normal.background = holdTexture;
		}
		if(holdSlot == "invSlot2")
		{
			i.invSlot2.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot3")
		{
			i.invSlot3.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot4")
		{
			i.invSlot4.normal.background = holdTexture;
		}
		if(holdSlot == "invSlot5")
		{
			i.invSlot5.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot6")
		{
			i.invSlot6.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot7")
		{
			i.invSlot7.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot8")
		{
			i.invSlot8.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot9")
		{
			i.invSlot9.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot10")
		{
			i.invSlot10.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot11")
		{
			i.invSlot11.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot12")
		{
			i.invSlot12.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot13")
		{
			i.invSlot13.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot14")
		{
			i.invSlot14.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot15")
		{
			i.invSlot15.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot16")
		{
			i.invSlot16.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot17")
		{
			i.invSlot17.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot18")
		{
			i.invSlot18.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot19")
		{
			i.invSlot19.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot20")
		{
			i.invSlot20.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot21")
		{
			i.invSlot21.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot22")
		{
			i.invSlot22.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot23")
		{
			i.invSlot23.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot24")
		{
			i.invSlot24.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot25")
		{
			i.invSlot25.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot26")
		{
			i.invSlot26.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot27")
		{
			i.invSlot27.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot28")
		{
			i.invSlot28.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot29")
		{
			i.invSlot29.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot30")
		{
			i.invSlot30.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot31")
		{
			i.invSlot31.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot32")
		{
			i.invSlot32.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot33")
		{
			i.invSlot33.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot34")
		{
			i.invSlot34.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot35")
		{
			i.invSlot35.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot36")
		{
			i.invSlot36.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot37")
		{
			i.invSlot37.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot38")
		{
			i.invSlot38.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot39")
		{
			i.invSlot39.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot40")
		{
			i.invSlot40.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot41")
		{
			i.invSlot41.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot42")
		{
			i.invSlot42.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot43")
		{
			i.invSlot43.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot44")
		{
			i.invSlot44.normal.background = holdTexture;		
		}
		if(holdSlot == "invSlot45")
		{
			i.invSlot45.normal.background = holdTexture;		
		}
		if(holdSlot == "bagSize")
		{
			i.bagSize.normal.background = holdTexture;
		}
		if(holdSlot == "head")
		{
			i.headStyle.normal.background = holdTexture;
		}
		if(holdSlot == "face")
		{
			i.faceStyle.normal.background = holdTexture;
		}
		if(holdSlot == "lEye")
		{
			i.lEyeStyle.normal.background = holdTexture;
		}
		if(holdSlot == "rEye")
		{
			i.rEyeStyle.normal.background = holdTexture;
		}
		if(holdSlot == "neck")
		{
			i.neckStyle.normal.background = holdTexture;
		}
		if(holdSlot == "shirt")
		{
			i.shirtStyle.normal.background = holdTexture;
		}
		if(holdSlot == "vest")
		{
			i.vestStyle.normal.background = holdTexture;
		}
		if(holdSlot == "jacket")
		{
			i.jacketStyle.normal.background = holdTexture;
		}
		if(holdSlot == "lShoulder")
		{
			i.lShoulderStyle.normal.background = holdTexture;
		}
		if(holdSlot == "rShoulder")
		{
			i.rShoulderStyle.normal.background = holdTexture;
		}
		if(holdSlot == "lWrist")
		{
			i.lWristStyle.normal.background = holdTexture;
		}
		if(holdSlot == "rWrist")
		{
			i.rWristStyle.normal.background = holdTexture;
		}
		if(holdSlot == "lHand")
		{
			i.lHandStyle.normal.background = holdTexture;
		}
		if(holdSlot == "rHand")
		{
			i.rHandStyle.normal.background = holdTexture;
		}
		if(holdSlot == "belt")
		{
			i.beltStyle.normal.background = holdTexture;
		}
		if(holdSlot == "pouch1")
		{
			i.pouch1Style.normal.background = holdTexture;
		}
		if(holdSlot == "pouch2")
		{
			i.pouch2Style.normal.background = holdTexture;
		}
		if(holdSlot == "pouch3")
		{
			i.pouch3Style.normal.background = holdTexture;
		}
		if(holdSlot == "pouch4")
		{
			i.pouch4Style.normal.background = holdTexture;
		}
		if(holdSlot == "pouch5")
		{
			i.pouch5Style.normal.background = holdTexture;
		}
		if(holdSlot == "pants")
		{
			i.pantsStyle.normal.background = holdTexture;
		}
		if(holdSlot == "rLeg")
		{
			i.rLegStyle.normal.background = holdTexture;
		}
		if(holdSlot == "lLeg")
		{
			i.lLegStyle.normal.background = holdTexture;
		}
		if(holdSlot == "boots")
		{
			i.bootsStyle.normal.background = holdTexture;
		}
		if(holdSlot == "lFoot")
		{
			i.lFootStyle.normal.background = holdTexture;
		}
		if(holdSlot == "rFoot")
		{
			i.rFootStyle.normal.background = holdTexture;
		}
		if(holdSlot == "pouch1hotbar")
		{
			i.pouch1hotbarStyle.normal.background = holdTexture;
		}
		
	}
	public void MoveCheck()
	{
		Inventory i = (Inventory)inventory.GetComponent("Inventory");
		
		if(curSlot == "invSlot1")
		{
			i.invSlot1.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "invSlot2")
		{
			i.invSlot2.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot3")
		{
			i.invSlot3.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot4")
		{
			i.invSlot4.normal.background = mouseDrawStyle.normal.background;	
		}
		if(curSlot == "invSlot5")
		{
			i.invSlot5.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot6")
		{
			i.invSlot6.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot7")
		{
			i.invSlot7.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot8")
		{
			i.invSlot8.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot9")
		{
			i.invSlot9.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot10")
		{
			i.invSlot10.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot11")
		{
			i.invSlot11.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot12")
		{
			i.invSlot12.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot13")
		{
			i.invSlot13.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot14")
		{
			i.invSlot14.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot15")
		{
			i.invSlot15.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot16")
		{
			i.invSlot16.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot17")
		{
			i.invSlot17.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot18")
		{
			i.invSlot18.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot19")
		{
			i.invSlot19.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot20")
		{
			i.invSlot20.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot21")
		{
			i.invSlot21.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot22")
		{
			i.invSlot22.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot23")
		{
			i.invSlot23.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot24")
		{
			i.invSlot24.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot25")
		{
			i.invSlot25.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot26")
		{
			i.invSlot26.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot27")
		{
			i.invSlot27.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot28")
		{
			i.invSlot28.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot29")
		{
			i.invSlot29.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot30")
		{
			i.invSlot30.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot31")
		{
			i.invSlot31.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot32")
		{
			i.invSlot32.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot33")
		{
			i.invSlot33.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot34")
		{
			i.invSlot34.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot35")
		{
			i.invSlot35.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot36")
		{
			i.invSlot36.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot37")
		{
			i.invSlot37.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot38")
		{
			i.invSlot38.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot39")
		{
			i.invSlot39.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot40")
		{
			i.invSlot40.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot41")
		{
			i.invSlot41.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot42")
		{
			i.invSlot42.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot43")
		{
			i.invSlot43.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot44")
		{
			i.invSlot44.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "invSlot45")
		{
			i.invSlot45.normal.background = mouseDrawStyle.normal.background;		
		}
		if(curSlot == "bagSize")
		{
			i.bagSize.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "head")
		{
			i.headStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "face")
		{
			i.faceStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "lEye")
		{
			i.lEyeStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "rEye")
		{
			i.rEyeStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "neck")
		{
			i.neckStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "shirt")
		{
			i.shirtStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "vest")
		{
			i.vestStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "jacket")
		{
			i.jacketStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "lShoulder")
		{
			i.lShoulderStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "rShoulder")
		{
			i.rShoulderStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "lWrist")
		{
			i.lWristStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "rWrist")
		{
			i.rWristStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "lHand")
		{
			i.lHandStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "rHand")
		{
			i.rHandStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "belt")
		{
			i.beltStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "pouch1")
		{
			i.pouch1Style.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "pouch2")
		{
			i.pouch2Style.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "pouch3")
		{
			i.pouch3Style.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "pouch4")
		{
			i.pouch4Style.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "pouch5")
		{
			i.pouch5Style.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "pants")
		{
			i.pantsStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "rLeg")
		{
			i.rLegStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "lLeg")
		{
			i.lLegStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "boots")
		{
			i.bootsStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "lFoot")
		{
			i.lFootStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "rFoot")
		{
			i.rFootStyle.normal.background = mouseDrawStyle.normal.background;
		}
		if(curSlot == "pouch1hotbar")
		{
			i.pouch1hotbarStyle.normal.background = mouseDrawStyle.normal.background;
		}
	}
	public void EmptySlot()
	{
		Inventory i = (Inventory)inventory.GetComponent("Inventory");
		
		if(curSlot == "invSlot1")
		{
			i.invSlot1.normal.background = emptyInv;
		}
		if(curSlot == "invSlot2")
		{
			i.invSlot2.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot3")
		{
			i.invSlot3.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot4")
		{
			i.invSlot4.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot5")
		{
			i.invSlot5.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot6")
		{
			i.invSlot6.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot7")
		{
			i.invSlot7.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot8")
		{
			i.invSlot8.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot9")
		{
			i.invSlot9.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot10")
		{
			i.invSlot10.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot11")
		{
			i.invSlot11.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot12")
		{
			i.invSlot12.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot13")
		{
			i.invSlot13.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot14")
		{
			i.invSlot14.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot15")
		{
			i.invSlot15.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot16")
		{
			i.invSlot16.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot17")
		{
			i.invSlot17.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot18")
		{
			i.invSlot18.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot19")
		{
			i.invSlot19.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot20")
		{
			i.invSlot20.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot21")
		{
			i.invSlot21.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot22")
		{
			i.invSlot22.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot23")
		{
			i.invSlot23.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot24")
		{
			i.invSlot24.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot25")
		{
			i.invSlot25.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot26")
		{
			i.invSlot26.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot27")
		{
			i.invSlot27.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot28")
		{
			i.invSlot28.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot29")
		{
			i.invSlot29.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot30")
		{
			i.invSlot30.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot31")
		{
			i.invSlot31.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot32")
		{
			i.invSlot32.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot33")
		{
			i.invSlot33.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot34")
		{
			i.invSlot34.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot35")
		{
			i.invSlot35.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot36")
		{
			i.invSlot36.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot37")
		{
			i.invSlot37.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot38")
		{
			i.invSlot38.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot39")
		{
			i.invSlot39.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot40")
		{
			i.invSlot40.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot41")
		{
			i.invSlot41.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot42")
		{
			i.invSlot42.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot43")
		{
			i.invSlot43.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot44")
		{
			i.invSlot44.normal.background = emptyInv;		
		}
		if(curSlot == "invSlot45")
		{
			i.invSlot45.normal.background = emptyInv;		
		}
		if(curSlot == "head")
		{
			i.headStyle.normal.background = emptyInv;
		}
		if(curSlot == "face")
		{
			i.faceStyle.normal.background = emptyInv;
		}
		if(curSlot == "lEye")
		{
			i.lEyeStyle.normal.background = emptyInv;
		}
		if(curSlot == "rEye")
		{
			i.rEyeStyle.normal.background = emptyInv;
		}
		if(curSlot == "neck")
		{
			i.neckStyle.normal.background = emptyInv;
		}
		if(curSlot == "shirt")
		{
			i.shirtStyle.normal.background = emptyInv;
		}
		if(curSlot == "vest")
		{
			i.vestStyle.normal.background = emptyInv;
		}
		if(curSlot == "jacket")
		{
			i.jacketStyle.normal.background = emptyInv;
		}
		if(curSlot == "lShoulder")
		{
			i.lShoulderStyle.normal.background = emptyInv;
		}
		if(curSlot == "rShoulder")
		{
			i.rShoulderStyle.normal.background = emptyInv;
		}
		if(curSlot == "lWrist")
		{
			i.lWristStyle.normal.background = emptyInv;
		}
		if(curSlot == "rWrist")
		{
			i.rWristStyle.normal.background = emptyInv;
		}
		if(curSlot == "lHand")
		{
			i.lHandStyle.normal.background = emptyInv;
		}
		if(curSlot == "rHand")
		{
			i.rHandStyle.normal.background = emptyInv;
		}
		if(curSlot == "belt")
		{
			i.beltStyle.normal.background = emptyInv;
		}
		if(curSlot == "pouch1")
		{
			i.pouch1Style.normal.background = emptyInv;
		}
		if(curSlot == "pouch2")
		{
			i.pouch2Style.normal.background = emptyInv;
		}
		if(curSlot == "pouch3")
		{
			i.pouch3Style.normal.background = emptyInv;
		}
		if(curSlot == "pouch4")
		{
			i.pouch4Style.normal.background = emptyInv;
		}
		if(curSlot == "pouch5")
		{
			i.pouch5Style.normal.background = emptyInv;
		}
		if(curSlot == "pants")
		{
			i.pantsStyle.normal.background = emptyInv;
		}
		if(curSlot == "rLeg")
		{
			i.rLegStyle.normal.background = emptyInv;
		}
		if(curSlot == "lLeg")
		{
			i.lLegStyle.normal.background = emptyInv;
		}
		if(curSlot == "boots")
		{
			i.bootsStyle.normal.background = emptyInv;
		}
		if(curSlot == "lFoot")
		{
			i.lFootStyle.normal.background = emptyInv;
		}
		if(curSlot == "rFoot")
		{
			i.rFootStyle.normal.background = emptyInv;
		}
		if(curSlot == "pouch1hotbar")
		{
			i.pouch1hotbarStyle.normal.background = emptyInv;
		}
	}
	
	
	
}
