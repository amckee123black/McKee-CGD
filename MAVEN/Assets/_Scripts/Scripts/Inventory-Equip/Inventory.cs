using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	
	public GameObject inventory;
	public string curInvSlot;
	
	public bool invSlotStatus;
	
	public bool pouch1status;
	public bool pouch2status;
	public bool pouch3status;
	public bool pouch4status;
	public bool pouch5status;
	
	public Camera EquipViewCamera;
	
	Texture2D emptyInv;
	
	Texture2D basicBag;
	Texture2D improvedBag;	
	
	public Texture2D curInvSlotTexture;
	
	
	private string destructionStatus;
	
	private string status = "closed";
	
	
	public GUIStyle inventoryBackgroundStyle;
	
	public GUIStyle bagSize;
	
	public GUIStyle backpack;
	public GUIStyle improvedBackpack;
	public GUIStyle superiorBackpack;
	public GUIStyle inventoryBackground;
	public GUIStyle weightTexture;
	public GUIStyle currencyTexture;
	public GUIStyle woodTexture;
	public GUIStyle metalTexture;
	public GUIStyle electronicTexture;
	public GUIStyle rubberTexture;
	public GUIStyle clothTexture;
	public GUIStyle countStyle;
	public GUIStyle trashStyle;
	
	public GUIStyle labelStyle;
	
	public GUIStyle warningBoxStyle;
	public GUIStyle yesStyle;
	public GUIStyle noStyle;
	
	public GUIStyle outlineTexture;
	
	public GUIStyle invSlot1;
	public GUIStyle invSlot2;
	public GUIStyle invSlot3;
	public GUIStyle invSlot4;
	public GUIStyle invSlot5;
	public GUIStyle invSlot6;
	public GUIStyle invSlot7;
	public GUIStyle invSlot8;
	public GUIStyle invSlot9;
	public GUIStyle invSlot10;
	public GUIStyle invSlot11;
	public GUIStyle invSlot12;
	public GUIStyle invSlot13;
	public GUIStyle invSlot14;
	public GUIStyle invSlot15;
	public GUIStyle invSlot16;
	public GUIStyle invSlot17;
	public GUIStyle invSlot18;
	public GUIStyle invSlot19;
	public GUIStyle invSlot20;
	public GUIStyle invSlot21;
	public GUIStyle invSlot22;
	public GUIStyle invSlot23;
	public GUIStyle invSlot24;
	public GUIStyle invSlot25;
	public GUIStyle invSlot26;
	public GUIStyle invSlot27;
	public GUIStyle invSlot28;
	public GUIStyle invSlot29;
	public GUIStyle invSlot30;
	public GUIStyle invSlot31;
	public GUIStyle invSlot32;
	public GUIStyle invSlot33;
	public GUIStyle invSlot34;
	public GUIStyle invSlot35;
	public GUIStyle invSlot36;
	public GUIStyle invSlot37;
	public GUIStyle invSlot38;
	public GUIStyle invSlot39;
	public GUIStyle invSlot40;
	public GUIStyle invSlot41;
	public GUIStyle invSlot42;
	public GUIStyle invSlot43;
	public GUIStyle invSlot44;
	public GUIStyle invSlot45;
	
	public GUIStyle headStyle;
	public GUIStyle faceStyle;
	public GUIStyle lEyeStyle;
	public GUIStyle rEyeStyle;
	public GUIStyle neckStyle;
	public GUIStyle shirtStyle;
	public GUIStyle vestStyle;
	public GUIStyle jacketStyle;
	public GUIStyle lShoulderStyle;
	public GUIStyle rShoulderStyle;
	public GUIStyle lWristStyle;
	public GUIStyle rWristStyle;
	public GUIStyle lHandStyle;
	public GUIStyle rHandStyle;
	public GUIStyle beltStyle;
	public GUIStyle pouch1Style;
	public GUIStyle pouch2Style;
	public GUIStyle pouch3Style;
	public GUIStyle pouch4Style;
	public GUIStyle pouch5Style;
	public GUIStyle pantsStyle;
	public GUIStyle rLegStyle;
	public GUIStyle lLegStyle;
	public GUIStyle bootsStyle;
	public GUIStyle lFootStyle;
	public GUIStyle rFootStyle;
	public GUIStyle equipBackgroundStyle;
	
	public GUIStyle pouch1hotbarStyle;
	public GUIStyle	pouch2hotbarStyle;
	public GUIStyle	pouch3hotbarStyle;
	public GUIStyle	pouch4hotbarStyle;
	public GUIStyle	pouch5hotbarStyle;
	
	public GUIStyle leftPockethotbarStyle;
	public GUIStyle	rightPockethotbarStyle;
	
	public GUIStyle vest1hotbarStyle;
	public GUIStyle	vest2hotbarStyle;
	public GUIStyle	vest3hotbarStyle;
	public GUIStyle	vest4hotbarStyle;
	public GUIStyle vest5hotbarStyle;
	
			
	
	
	public GUIStyle mouseHoldStyle;
	
	public int bagSwitch = 0;
	public int invSlotCheck = 0;
	
	public float curWeight = 0;
	public float maxWeight = 0;
	
	public int currency;
	public int wood = 0;
	public int metal = 0;
	public int electronic = 0;
	public int rubber = 0;
	public int cloth = 0;
	
	public bool cameraShow = false;
	
	void Awake ()
	{
		basicBag = Resources.Load("Textures/Inventory/BasicBag", typeof(Texture2D)) as Texture2D;
		improvedBag = Resources.Load("Textures/Inventory/ImprovedBag", typeof(Texture2D)) as Texture2D; 
		emptyInv = Resources.Load("Textures/Inventory/EmptyInv", typeof(Texture2D)) as Texture2D;
		
		invSlot1.normal.background = basicBag;
		
	}
	
	
	// Use this for initialization
	void Start () 
	{
		inventory = GameObject.FindGameObjectWithTag("Inventory");
		
		EquipViewCamera.camera.active = false;
		
		bagSize.normal.background = basicBag;
		
		
		
		
		
		invSlot2.normal.background = basicBag;
		invSlot3.normal.background = emptyInv;
		invSlot4.normal.background = emptyInv;
		invSlot5.normal.background = emptyInv;
		invSlot6.normal.background = emptyInv;
		invSlot7.normal.background = emptyInv;
		invSlot8.normal.background = emptyInv;
		invSlot9.normal.background = emptyInv;
		invSlot10.normal.background = emptyInv;
		invSlot11.normal.background = emptyInv;
		invSlot12.normal.background = emptyInv;
		invSlot13.normal.background = emptyInv;
		invSlot14.normal.background = emptyInv;
		invSlot15.normal.background = emptyInv;
		invSlot16.normal.background = emptyInv;
		invSlot17.normal.background = emptyInv;
		invSlot18.normal.background = emptyInv;
		invSlot19.normal.background = emptyInv;
		invSlot20.normal.background = emptyInv;
		invSlot21.normal.background = emptyInv;
		invSlot22.normal.background = emptyInv;
		invSlot23.normal.background = emptyInv;
		invSlot24.normal.background = emptyInv;
		invSlot25.normal.background = emptyInv;
		invSlot26.normal.background = emptyInv;
		invSlot27.normal.background = emptyInv;
		invSlot28.normal.background = emptyInv;
		invSlot29.normal.background = emptyInv;
		invSlot30.normal.background = emptyInv;
		invSlot31.normal.background = emptyInv;
		invSlot32.normal.background = emptyInv;
		invSlot33.normal.background = emptyInv;
		invSlot34.normal.background = emptyInv;
		invSlot35.normal.background = emptyInv;
		invSlot36.normal.background = emptyInv;
		invSlot37.normal.background = emptyInv;
		invSlot38.normal.background = emptyInv;
		invSlot39.normal.background = emptyInv;
		invSlot40.normal.background = emptyInv;
		invSlot41.normal.background = emptyInv;
		invSlot42.normal.background = emptyInv;
		invSlot43.normal.background = emptyInv;
		invSlot44.normal.background = emptyInv;
		invSlot45.normal.background = emptyInv;
		
		headStyle.normal.background = emptyInv;
		faceStyle.normal.background = emptyInv;
		lEyeStyle.normal.background = emptyInv;
		rEyeStyle.normal.background = emptyInv;
		neckStyle.normal.background = emptyInv;
		shirtStyle.normal.background = emptyInv;
		vestStyle.normal.background = emptyInv;
		jacketStyle.normal.background = emptyInv;
		lShoulderStyle.normal.background = emptyInv;
		rShoulderStyle.normal.background = emptyInv;
		lWristStyle.normal.background = emptyInv;
		rWristStyle.normal.background = emptyInv;
		lHandStyle.normal.background = emptyInv;
		rHandStyle.normal.background = emptyInv;
		beltStyle.normal.background = emptyInv;
		pouch1Style.normal.background = emptyInv;
		pouch2Style.normal.background = emptyInv;
		pouch3Style.normal.background = emptyInv;
		pouch4Style.normal.background = emptyInv;
		pouch5Style.normal.background = emptyInv;
		pantsStyle.normal.background = emptyInv;
		lLegStyle.normal.background = emptyInv;
		rLegStyle.normal.background = emptyInv;
		bootsStyle.normal.background = emptyInv;
		lFootStyle.normal.background = emptyInv;
		rFootStyle.normal.background = emptyInv;
		
	
		
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyUp (KeyCode.I))
		{
			Display();
			
		}
		
		
		invSlotCheck = 0;
		
		DragDrop chs = (DragDrop)inventory.GetComponent("DragDrop");
		chs.curSlotTexture = curInvSlotTexture;
		chs.curSlot = curInvSlot;

		
		
		

	}
	
	void OnGUI()
	{
		Draw ();
		PouchSlots();
		PocketSlots();
		VestSlots();
	}
	
	private void Display()
	{
			if(status == "closed")
			{
				status = "opened";
				EquipViewCamera.camera.active = true;
			}
			else if (status == "opened")
			{
				status = "closed";
				EquipViewCamera.camera.active = false;
			}
		
	}
	private void Draw()
	{
		
		if(status == "opened")
		{
			Background();
			Labels ();
			DrawInventory();
			BagSize();
			EquipSlots ();
		}
		
	}
	

	
	void BagSize()
	{
		
		DragDrop chs = (DragDrop)inventory.GetComponent("DragDrop");
		
		var xPos = Screen.width / 1.7f;
		var yPos = Screen.height / 3;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		
		var yspacing = Screen.height / 10;
		
		Rect bs = new Rect(xPos, yPos - yspacing, width, height);
		GUI.Box (bs, "",bagSize);
		
		if(bs.Contains(Event.current.mousePosition))
			{
				GUI.Box (bs, "", outlineTexture);
				invSlotCheck = 1;
			
				chs.slotCheck = invSlotCheck;
				curInvSlot = "bagSize";
				curInvSlotTexture = bagSize.normal.background;
				
				if(bagSize.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(bagSize.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}	
		
	if(bagSize.normal.background == basicBag)
		{
			bagSwitch = 1;
		}
	if(bagSize.normal.background == improvedBag)
		{
			bagSwitch = 2;
		}
	if(bagSize.normal.background == backpack.normal.background)
		{
			bagSwitch = 3;
		}
	if(bagSize.normal.background == improvedBackpack.normal.background)
		{
			bagSwitch = 4;
		}
	if(bagSize.normal.background == superiorBackpack.normal.background)
		{
			bagSwitch = 5;
		}
	if(bagSize.normal.background == emptyInv)
		{
			bagSwitch = 0;
		}
	}
	private void TrashSlot()
	{
		var xPos = Screen.width / 1.7f;
		var yPos = Screen.height / 3;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 500;
		var yspacing = Screen.height / 10;
		
		Rect trashSlot = new Rect(xPos + ((width + xspacing) * 3), yPos - yspacing, width, height);
		GUI.Box (trashSlot, "Trash", trashStyle);
		
		if(trashSlot.Contains(Event.current.mousePosition))
		{
			GUI.Box (trashSlot, "", outlineTexture);
			invSlotCheck = 1;
				if(Input.GetMouseButton(0) == false && mouseHoldStyle.normal.background != null)
				{
					mouseHoldStyle.normal.background = null;
	
				}
		}
	}
	private void WoodSlot()
	{
		var xPos = Screen.width / 1.7f;
		var yPos = Screen.height / 3;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 500;
		var yspacing = Screen.height / 10;
	
		Rect woodSlot = new Rect(xPos + ((width + xspacing) * 4), yPos - yspacing, width, height);
		GUI.Box (woodSlot, "Wood", woodTexture);
		
		Rect woodcountSlot = new Rect(xPos + ((width + xspacing) * 4), yPos - yspacing, width, height);
		GUI.Box (woodcountSlot, "" + wood, countStyle);
	}
	private void MetalSlot()
	{
		var xPos = Screen.width / 1.7f;
		var yPos = Screen.height / 3;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 500;
		var yspacing = Screen.height / 10;
		
		Rect metalSlot = new Rect(xPos + ((width + xspacing) * 5), yPos - yspacing, width, height);
		GUI.Box (metalSlot, "Metal", metalTexture);
		
		Rect metalcountSlot = new Rect(xPos + ((width + xspacing) * 5), yPos - yspacing, width, height);
		GUI.Box (metalcountSlot, "" + metal, countStyle);
	}
	private void ElectronicSlot()
	{
		var xPos = Screen.width / 1.7f;
		var yPos = Screen.height / 3;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 500;
		var yspacing = Screen.height / 10;
		
		Rect electronicSlot = new Rect(xPos + ((width + xspacing) * 6), yPos - yspacing, width, height);
		GUI.Box (electronicSlot, "Elec", electronicTexture);
			
		Rect electroniccountSlot = new Rect(xPos + ((width + xspacing) * 6), yPos - yspacing, width, height);
		GUI.Box (electroniccountSlot, "" + electronic, countStyle);
	}
	private void RubberSlot()
	{
		var xPos = Screen.width / 1.7f;
		var yPos = Screen.height / 3;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 500;
		var yspacing = Screen.height / 10;
		
		Rect rubberSlot = new Rect(xPos + ((width + xspacing) * 7), yPos - yspacing, width, height);
		GUI.Box (rubberSlot, "Rubber", rubberTexture);
		
		Rect rubbercountSlot = new Rect(xPos + ((width + xspacing) * 7), yPos - yspacing, width, height);
		GUI.Box (rubbercountSlot, "" + rubber, countStyle);
	}
	private void ClothSlot()
	{
		var xPos = Screen.width / 1.7f;
		var yPos = Screen.height / 3;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 500;
		var yspacing = Screen.height / 10;
		
		Rect clothSlot = new Rect(xPos + ((width + xspacing) * 8), yPos - yspacing, width, height);
		GUI.Box (clothSlot, "Cloth", clothTexture);
		
		Rect clothcountSlot = new Rect(xPos + ((width + xspacing) * 8), yPos - yspacing, width, height);
		GUI.Box (clothcountSlot, "" + cloth, countStyle);
	}
	
	public void DrawInventory()
	{
		DragDrop chs = (DragDrop)inventory.GetComponent("DragDrop");
		
		
		WoodSlot();
		MetalSlot();
		ElectronicSlot();
		RubberSlot();
		ClothSlot();
		TrashSlot();
		
		var xPos = Screen.width / 1.7f;
		var yPos = Screen.height / 3;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 500;
		var yspacing = Screen.height / 100;
		
		
		Rect slot1 = new Rect(xPos, yPos, width, height);
		Rect slot2 = new Rect(xPos + (width + xspacing), yPos, width, height);
		Rect slot3 = new Rect(xPos + ((width  + xspacing) * 2), yPos, width, height);
		Rect slot4 = new Rect(xPos + ((width  + xspacing) * 3), yPos, width, height);
		Rect slot5 = new Rect(xPos + ((width  + xspacing) * 4), yPos, width, height);
		Rect slot6 = new Rect(xPos + ((width  + xspacing) * 5), yPos, width, height);
		Rect slot7 = new Rect(xPos + ((width  + xspacing) * 6), yPos, width, height);
		Rect slot8 = new Rect(xPos + ((width  + xspacing) * 7), yPos, width, height);
		Rect slot9 = new Rect(xPos + ((width  + xspacing) * 8), yPos, width, height);
		Rect slot10 = new Rect(xPos, yPos + (height + yspacing), width, height);
		Rect slot11 = new Rect(xPos + (width + xspacing), yPos + (height + yspacing), width, height);
		Rect slot12 = new Rect(xPos + ((width  + xspacing) * 2), yPos + (height + yspacing), width, height);
		Rect slot13 = new Rect(xPos + ((width  + xspacing) * 3), yPos + (height + yspacing), width, height);
		Rect slot14 = new Rect(xPos + ((width  + xspacing) * 4), yPos + (height + yspacing), width, height);
		Rect slot15 = new Rect(xPos + ((width  + xspacing) * 5), yPos + (height + yspacing), width, height);
		Rect slot16 = new Rect(xPos + ((width  + xspacing) * 6), yPos + (height + yspacing), width, height);
		Rect slot17 = new Rect(xPos + ((width  + xspacing) * 7), yPos + (height + yspacing), width, height);
		Rect slot18 = new Rect(xPos + ((width  + xspacing) * 8), yPos + (height + yspacing), width, height);
		Rect slot19 = new Rect(xPos, yPos + ((height + yspacing) * 2), width, height);
		Rect slot20 = new Rect(xPos + (width + xspacing), yPos + ((height + yspacing) * 2), width, height);
		Rect slot21 = new Rect(xPos + ((width  + xspacing) * 2), yPos + ((height + yspacing) * 2), width, height);
		Rect slot22 = new Rect(xPos + ((width  + xspacing) * 3), yPos + ((height + yspacing) * 2), width, height);
		Rect slot23 = new Rect(xPos + ((width  + xspacing) * 4), yPos + ((height + yspacing) * 2), width, height);
		Rect slot24 = new Rect(xPos + ((width  + xspacing) * 5), yPos + ((height + yspacing) * 2), width, height);
		Rect slot25 = new Rect(xPos + ((width  + xspacing) * 6), yPos + ((height + yspacing) * 2), width, height);
		Rect slot26 = new Rect(xPos + ((width  + xspacing) * 7), yPos + ((height + yspacing) * 2), width, height);
		Rect slot27 = new Rect(xPos + ((width  + xspacing) * 8), yPos + ((height + yspacing) * 2), width, height);
		Rect slot28 = new Rect(xPos, yPos + ((height + yspacing) * 3), width, height);
		Rect slot29 = new Rect(xPos + (width + xspacing), yPos + ((height + yspacing) * 3), width, height);
		Rect slot30 = new Rect(xPos + ((width  + xspacing) * 2), yPos + ((height + yspacing) * 3), width, height);
		Rect slot31 = new Rect(xPos + ((width  + xspacing) * 3), yPos + ((height + yspacing) * 3), width, height);
		Rect slot32 = new Rect(xPos + ((width  + xspacing) * 4), yPos + ((height + yspacing) * 3), width, height);
		Rect slot33 = new Rect(xPos + ((width  + xspacing) * 5), yPos + ((height + yspacing) * 3), width, height);
		Rect slot34 = new Rect(xPos + ((width  + xspacing) * 6), yPos + ((height + yspacing) * 3), width, height);
		Rect slot35 = new Rect(xPos + ((width  + xspacing) * 7), yPos + ((height + yspacing) * 3), width, height);
		Rect slot36 = new Rect(xPos + ((width  + xspacing) * 8), yPos + ((height + yspacing) * 3), width, height);
		Rect slot37 = new Rect(xPos, yPos + ((height + yspacing) * 4), width, height);
		Rect slot38 = new Rect(xPos + (width + xspacing), yPos + ((height + yspacing) * 4), width, height);
		Rect slot39 = new Rect(xPos + ((width  + xspacing) * 2), yPos + ((height + yspacing) * 4), width, height);
		Rect slot40 = new Rect(xPos + ((width  + xspacing) * 3), yPos + ((height + yspacing) * 4), width, height);
		Rect slot41 = new Rect(xPos + ((width  + xspacing) * 4), yPos + ((height + yspacing) * 4), width, height);
		Rect slot42 = new Rect(xPos + ((width  + xspacing) * 5), yPos + ((height + yspacing) * 4), width, height);
		Rect slot43 = new Rect(xPos + ((width  + xspacing) * 6), yPos + ((height + yspacing) * 4), width, height);
		Rect slot44 = new Rect(xPos + ((width  + xspacing) * 7), yPos + ((height + yspacing) * 4), width, height);
		Rect slot45 = new Rect(xPos + ((width  + xspacing) * 8), yPos + ((height + yspacing) * 4), width, height);

			
	if(bagSwitch == 1 || bagSwitch == 2 || bagSwitch == 3 || bagSwitch == 4 || bagSwitch == 5) 		
		{	
			GUI.Box (slot1, "", invSlot1);
			GUI.Box (slot2, "", invSlot2);
			GUI.Box (slot3, "", invSlot3);
			GUI.Box (slot4, "", invSlot4);
			GUI.Box (slot5, "", invSlot5);
			GUI.Box (slot6, "", invSlot6);
			GUI.Box (slot7, "", invSlot7);
			GUI.Box (slot8, "", invSlot8);
			GUI.Box (slot9, "", invSlot9);
		}
	if(bagSwitch ==2 || bagSwitch == 3 || bagSwitch == 4 || bagSwitch ==5)
		{
			GUI.Box (slot10, "", invSlot10);
			GUI.Box (slot11, "", invSlot11);
			GUI.Box (slot12, "", invSlot12);
			GUI.Box (slot13, "", invSlot13);
			GUI.Box (slot14, "", invSlot14);
			GUI.Box (slot15, "", invSlot15);
			GUI.Box (slot16, "", invSlot16);
			GUI.Box (slot17, "", invSlot17);
			GUI.Box (slot18, "", invSlot18);
		}
	if(bagSwitch == 3 || bagSwitch == 4 || bagSwitch ==5)
		{
			GUI.Box (slot19, "", invSlot19);
			GUI.Box (slot20, "", invSlot20);
			GUI.Box (slot21, "", invSlot21);
			GUI.Box (slot22, "", invSlot22);
			GUI.Box (slot23, "", invSlot23);
			GUI.Box (slot24, "", invSlot24);
			GUI.Box (slot25, "", invSlot25);
			GUI.Box (slot26, "", invSlot26);
			GUI.Box (slot27, "", invSlot27);
		}
	if(bagSwitch == 4 || bagSwitch ==5)
		{
			GUI.Box (slot28, "", invSlot28);
			GUI.Box (slot29, "", invSlot29);
			GUI.Box (slot30, "", invSlot30);
			GUI.Box (slot31, "", invSlot31);
			GUI.Box (slot32, "", invSlot32);	
			GUI.Box (slot33, "", invSlot33);
			GUI.Box (slot34, "", invSlot34);
			GUI.Box (slot35, "", invSlot35);
			GUI.Box (slot36, "", invSlot36);
		}
	if(bagSwitch ==5)
		{
			GUI.Box (slot37, "", invSlot37);
			GUI.Box (slot38, "", invSlot38);
			GUI.Box (slot39, "", invSlot39);
			GUI.Box (slot40, "", invSlot40);
			GUI.Box (slot41, "", invSlot41);
			GUI.Box (slot42, "", invSlot42);
			GUI.Box (slot43, "", invSlot43);
			GUI.Box (slot44, "", invSlot44);
			GUI.Box (slot45, "", invSlot45);
		}
		
		
		
		Rect weightBox = new Rect(xPos + ((width + xspacing) * 7), yPos + ((height + yspacing) * 5), width * 2, height);
		GUI.Box (weightBox, "Weight         " + curWeight + "/" + maxWeight, weightTexture);
		
		Rect currencyBox = new Rect(xPos, yPos + ((height + yspacing) * 5), width * 7, height);
		GUI.Box(currencyBox, "$" + currency, currencyTexture);
		
	if(bagSwitch == 1 || bagSwitch == 2 || bagSwitch == 3 || bagSwitch == 4 || bagSwitch == 5) 
		{
		
			if(slot1.Contains(Event.current.mousePosition))
			{
				GUI.Box (slot1, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot1";
				curInvSlotTexture = invSlot1.normal.background;
				
				if(invSlot1.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot1.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
				
			}
			
				
			
			if(slot2.Contains(Event.current.mousePosition))
			{
				GUI.Box (slot2, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot2";
				curInvSlotTexture = invSlot2.normal.background;
				
				if(invSlot2.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot2.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		
		
			
			if(slot3.Contains(Event.current.mousePosition))
			{
				GUI.Box (slot3, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot3";
				curInvSlotTexture = invSlot3.normal.background;
				
				if(invSlot3.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot3.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		
		
	
			if(slot4.Contains(Event.current.mousePosition))
			{
				GUI.Box (slot4, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot4";
				curInvSlotTexture = invSlot4.normal.background;
				
				if(invSlot4.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot4.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		
		
	
			if(slot5.Contains(Event.current.mousePosition))
			{
				GUI.Box (slot5, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot5";
				curInvSlotTexture = invSlot5.normal.background;
				
				if(invSlot5.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot5.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		

	
			if(slot6.Contains(Event.current.mousePosition))
			{
				GUI.Box (slot6, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot6";
				curInvSlotTexture = invSlot6.normal.background;
				
				if(invSlot6.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot6.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}		
		

			
			if(slot7.Contains(Event.current.mousePosition))
			{
				GUI.Box (slot7, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot7";
				curInvSlotTexture = invSlot7.normal.background;
				
				if(invSlot7.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot7.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		
	
			
			if(slot8.Contains(Event.current.mousePosition))
			{
				GUI.Box (slot8, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot8";
				curInvSlotTexture = invSlot8.normal.background;
				
				if(invSlot8.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot8.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		

			
			if(slot9.Contains(Event.current.mousePosition))
			{
				GUI.Box (slot9, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot9";
				curInvSlotTexture = invSlot9.normal.background;
				
				if(invSlot9.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot9.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		}
	if(bagSwitch == 2 || bagSwitch == 3 || bagSwitch == 4 || bagSwitch == 5) 
		{
			if(slot10.Contains(Event.current.mousePosition))
			{
			GUI.Box (slot10, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot10";
				curInvSlotTexture = invSlot10.normal.background;
				
				if(invSlot10.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot10.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}	
		
		
		
		if(slot11.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot11, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot11";
				curInvSlotTexture = invSlot11.normal.background;
				
				if(invSlot11.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot11.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
		
				

		
		if(slot12.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot12, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot12";
				curInvSlotTexture = invSlot12.normal.background;
				
				if(invSlot12.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot12.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
		

		
		if(slot13.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot13, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot13";
				curInvSlotTexture = invSlot5.normal.background;
				
				if(invSlot13.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot13.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		

		
		if(slot14.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot14, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot14";
				curInvSlotTexture = invSlot14.normal.background;
				
				if(invSlot14.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot14.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}

		
		if(slot15.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot15, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot15";
				curInvSlotTexture = invSlot15.normal.background;
				
				if(invSlot15.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot15.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
	
		
		if(slot16.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot16, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot16";
				curInvSlotTexture = invSlot16.normal.background;
				
				if(invSlot16.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot16.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}		
		
		
		
		if(slot17.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot17, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot17";
				curInvSlotTexture = invSlot17.normal.background;
				
				if(invSlot17.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot17.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		
	
		
		if(slot18.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot18, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot18";
				curInvSlotTexture = invSlot18.normal.background;
				
				if(invSlot18.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot18.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
	}
	if(bagSwitch == 3 || bagSwitch == 4 || bagSwitch == 5)
		{
		if(slot19.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot19, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot19";
				curInvSlotTexture = invSlot19.normal.background;
				
				if(invSlot19.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot19.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
		

		
		if(slot20.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot20, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot20";
				curInvSlotTexture = invSlot20.normal.background;
				
				if(invSlot20.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot20.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		

		
		if(slot21.Contains(Event.current.mousePosition))
		{
				GUI.Box (slot21, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot21";
				curInvSlotTexture = invSlot21.normal.background;
				
				if(invSlot21.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot21.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}

		
		if(slot22.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot22, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot22";
				curInvSlotTexture = invSlot22.normal.background;
				
				if(invSlot22.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot22.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		
				

		
		if(slot23.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot23, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot23";
				curInvSlotTexture = invSlot23.normal.background;
				
				if(invSlot23.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot23.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
		

		
		if(slot24.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot24, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot24";
				curInvSlotTexture = invSlot24.normal.background;
				
				if(invSlot24.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot24.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
		

		
		if(slot25.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot25, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot25";
				curInvSlotTexture = invSlot25.normal.background;
				
				if(invSlot25.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot25.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		

		
		if(slot26.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot26, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot26";
				curInvSlotTexture = invSlot26.normal.background;
				
				if(invSlot26.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot26.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
		

		
		if(slot27.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot27, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot27";
				curInvSlotTexture = invSlot27.normal.background;
				
				if(invSlot27.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot27.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		
	}
	if(bagSwitch == 4 || bagSwitch == 5) 
		{
		if(slot28.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot28, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot28";
				curInvSlotTexture = invSlot28.normal.background;
				
				if(invSlot28.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot28.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
		

		
		if(slot29.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot29, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot29";
				curInvSlotTexture = invSlot29.normal.background;
				
				if(invSlot29.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot29.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
		

		
		if(slot30.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot30, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot30";
				curInvSlotTexture = invSlot30.normal.background;
				
				if(invSlot30.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot30.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}		
		
		
		
		if(slot31.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot31, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot31";
				curInvSlotTexture = invSlot31.normal.background;
				
				if(invSlot31.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot31.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
	
		
		
		if(slot32.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot32, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot32";
				curInvSlotTexture = invSlot32.normal.background;
				
				if(invSlot32.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot32.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
	
		
		
		if(slot33.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot33, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot33";
				curInvSlotTexture = invSlot33.normal.background;
				
				if(invSlot33.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot33.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		
		
		
		if(slot34.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot34, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot34";
				curInvSlotTexture = invSlot34.normal.background;
				
				if(invSlot34.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot34.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
		
	
		
		if(slot35.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot35, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot35";
				curInvSlotTexture = invSlot35.normal.background;
				
				if(invSlot35.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot35.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
		
	
		
		if(slot36.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot36, "", outlineTexture);
			invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot36";
				curInvSlotTexture = invSlot36.normal.background;
				
				if(invSlot36.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot36.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		
		}
	if(bagSwitch == 5) 
		{
		
		if(slot37.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot37, "", outlineTexture);
			invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot37";
				curInvSlotTexture = invSlot37.normal.background;
				
				if(invSlot37.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot37.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		
	
		
		if(slot38.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot38, "", outlineTexture);
			invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot38";
				curInvSlotTexture = invSlot38.normal.background;
				
				if(invSlot38.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot38.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		
	
		
		if(slot39.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot39, "", outlineTexture);
			invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot39";
				curInvSlotTexture = invSlot39.normal.background;
				
				if(invSlot39.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot39.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		
	
		
		if(slot40.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot40, "", outlineTexture);
			invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot40";
				curInvSlotTexture = invSlot40.normal.background;
				
				if(invSlot40.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot40.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		

		
		if(slot41.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot41, "", outlineTexture);
			invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot41";
				curInvSlotTexture = invSlot41.normal.background;
				
				if(invSlot41.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot41.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		
			
		
		if(slot42.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot42, "", outlineTexture);
			invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot42";
				curInvSlotTexture = invSlot42.normal.background;
				
				if(invSlot42.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot42.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
		
		
		
		if(slot43.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot43, "", outlineTexture);
			invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot43";
				curInvSlotTexture = invSlot43.normal.background;
				
				if(invSlot43.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot43.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}	
		
	
		
		if(slot44.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot44, "", outlineTexture);
			invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot44";
				curInvSlotTexture = invSlot44.normal.background;
				
				if(invSlot44.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot44.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
		
	
		
		if(slot45.Contains(Event.current.mousePosition))
		{
			GUI.Box (slot45, "", outlineTexture);
			invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "invSlot45";
				curInvSlotTexture = invSlot45.normal.background;
				
				if(invSlot45.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(invSlot45.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
		}
		
		}
	}

	private void ItemDestruction()
	{
		//Draw a box in the middle of the screen with a yes and no button for destruction
		var xPos = Screen.width / 2.5f;
		var yPos = Screen.height / 3;
		var width = Screen.width / 4.3f;
		var height = Screen.height/ 4;
			
		Rect warningBox = new Rect(xPos, yPos, width, height);
		GUI.Box(warningBox, "Are You Sure You Wanna Destroy This.", warningBoxStyle);
		
		Rect yesButton = new Rect(Screen.width / 2.3f, Screen.height / 2.3f, Screen.width / 24, Screen.height /12);
		Rect noButton = new Rect(Screen.width / 1.8f, Screen.height / 2.3f, Screen.width / 24, Screen.height /12);
		
		
		
			if(GUI.Button(yesButton, "YES", yesStyle))
			{
			
			}
			if(GUI.Button(noButton, "NO", noStyle))
			{
			
			}
	}
	private void Labels()
	{
		var xPos = Screen.width / 500;
		var yPos = Screen.height / 3;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var yspacing = Screen.height / 100;
		
		
		Rect headLabel = new Rect(xPos , yPos - (Screen.height / 10), width, height);
		GUI.Box (headLabel, "HEAD", labelStyle);
		
		Rect neckLabel = new Rect(xPos , yPos, width, height);
		GUI.Box (neckLabel, "NECK", labelStyle);
		
		Rect chestLabel = new Rect(xPos , yPos + (height + yspacing), width, height);
		GUI.Box (chestLabel, "CHEST", labelStyle);
		
		Rect armsLabel = new Rect(xPos , yPos + ((height + yspacing) * 2), width, height);
		GUI.Box (armsLabel, "ARMS", labelStyle);
		
		Rect waistLabel = new Rect(xPos , yPos + ((height + yspacing) * 3), width, height);
		GUI.Box (waistLabel, "WAIST", labelStyle);
		
		Rect legsLabel = new Rect(xPos , yPos + ((height + yspacing) * 4), width, height);
		GUI.Box (legsLabel, "LEGS", labelStyle);
		
		Rect feetLabel = new Rect(xPos , yPos + ((height + yspacing) * 5), width, height);
		GUI.Box (feetLabel, "FEET", labelStyle);
	}
	public void EquipSlots()
		
	{
		
		DragDrop chs = (DragDrop)inventory.GetComponent("DragDrop");
		
		var xPos = Screen.width / 500;
		var yPos = Screen.height / 3;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 500;
		var yspacing = Screen.height / 100;
		
		
		
		Rect head = new Rect(xPos + ((width + xspacing) * 2), yPos -  (Screen.height / 10), width, height);
		GUI.Box (head, "Head", headStyle);
		
		
			
		Rect face = new Rect(xPos + ((width + xspacing) * 4), yPos -  (Screen.height / 10), width, height);
		GUI.Box (face, "Face", faceStyle);
		
		Rect lEye = new Rect(xPos + ((width + xspacing) * 6), yPos -  (Screen.height / 10), width, height);
		GUI.Box (lEye, "LeftEye", lEyeStyle);
		
		Rect rEye = new Rect(xPos + ((width + xspacing) * 7), yPos -  (Screen.height / 10), width, height);
		GUI.Box (rEye, "RightEye", rEyeStyle);
		
		Rect neck = new Rect(xPos + ((width + xspacing) * 2), yPos, width, height);
		GUI.Box (neck, "Neck", neckStyle);
		
		Rect shirt = new Rect(xPos + ((width + xspacing) * 2), yPos + (height + yspacing), width, height);
		GUI.Box (shirt, "Shirt", shirtStyle);
		
		Rect vest = new Rect(xPos + ((width + xspacing) * 4), yPos + (height + yspacing), width, height);
		GUI.Box (vest, "Vest", vestStyle);
		
		Rect jacket = new Rect(xPos + ((width + xspacing) * 6), yPos + (height + yspacing), width, height);
		GUI.Box (jacket, "Jacket", jacketStyle);
		
		Rect lShoulder = new Rect(xPos + ((width + xspacing) * 2), yPos + ((height + yspacing) * 2), width, height);
		GUI.Box (lShoulder, "LeftShoulder", lShoulderStyle);
		
		Rect rShoulder = new Rect(xPos + ((width + xspacing) * 3), yPos + ((height + yspacing) * 2), width, height);
		GUI.Box (rShoulder, "RightShoulder", rShoulderStyle);
		
		Rect lWrist = new Rect(xPos + ((width + xspacing) * 5), yPos + ((height + yspacing) * 2), width, height);
		GUI.Box (lWrist, "LeftWrist", lWristStyle);
		
		Rect rWrist = new Rect(xPos + ((width + xspacing) * 6), yPos + ((height + yspacing) * 2), width, height);
		GUI.Box (rWrist, "RightWrist", rWristStyle);
		
		Rect lHand = new Rect(xPos + ((width + xspacing) * 8), yPos + ((height + yspacing) * 2), width, height);
		GUI.Box (lHand, "LeftHand", lHandStyle);
		
		Rect rHand = new Rect(xPos + ((width + xspacing) * 9), yPos + ((height + yspacing) * 2), width, height);
		GUI.Box (rHand, "RightHand", rHandStyle);
		
		Rect belt = new Rect(xPos + ((width + xspacing) * 2), yPos + ((height + yspacing) * 3), width, height);
		GUI.Box (belt, "Belt", beltStyle);
		
		Rect pouch1 = new Rect(xPos + ((width + xspacing) * 4), yPos + ((height + yspacing) * 3), width, height);
		GUI.Box (pouch1, "P1", pouch1Style);
		
		Rect pouch2 = new Rect(xPos + ((width + xspacing) * 5), yPos + ((height + yspacing) * 3), width, height);
		GUI.Box (pouch2, "P2", pouch2Style);
		
		Rect pouch3 = new Rect(xPos + ((width + xspacing) * 6), yPos + ((height + yspacing) * 3), width, height);
		GUI.Box (pouch3, "P3", pouch3Style);
		
		Rect pouch4 = new Rect(xPos + ((width + xspacing) * 7), yPos + ((height + yspacing) * 3), width, height);
		GUI.Box (pouch4, "P4", pouch4Style);
		
		Rect pouch5 = new Rect(xPos + ((width + xspacing) * 8), yPos + ((height + yspacing) * 3), width, height);
		GUI.Box (pouch5, "P5", pouch5Style);
		
		Rect pants = new Rect(xPos + ((width + xspacing) * 2), yPos + ((height + yspacing) * 4), width, height);
		GUI.Box (pants, "Pants", pantsStyle);
		
		Rect lLeg = new Rect(xPos + ((width + xspacing) * 4), yPos + ((height + yspacing) * 4), width, height);
		GUI.Box (lLeg, "LeftLeg", lLegStyle);
		
		Rect rLeg = new Rect(xPos + ((width + xspacing) * 5), yPos + ((height + yspacing) * 4), width, height);
		GUI.Box (rLeg, "RightLeg", rLegStyle);
		
		Rect boots = new Rect(xPos + ((width + xspacing) * 2), yPos + ((height + yspacing) * 5), width, height);
		GUI.Box (boots, "Boots", bootsStyle);
		
		Rect lFoot = new Rect(xPos + ((width + xspacing) * 4), yPos + ((height + yspacing) * 5), width, height);
		GUI.Box (lFoot, "LeftFoot", lFootStyle);
		
		Rect rFoot = new Rect(xPos + ((width + xspacing) * 5), yPos + ((height + yspacing) * 5), width, height);
		GUI.Box (rFoot, "RightFoot", rFootStyle);
		
		
		
		
		if(head.Contains(Event.current.mousePosition))
			{
				GUI.Box (head, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "head";
				curInvSlotTexture = headStyle.normal.background;
				
				if(headStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(headStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(face.Contains(Event.current.mousePosition))
			{
				GUI.Box (face, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "face";
				curInvSlotTexture = faceStyle.normal.background;
				
				if(faceStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(faceStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(lEye.Contains(Event.current.mousePosition))
			{
				GUI.Box (lEye, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "lEye";
				curInvSlotTexture = lEyeStyle.normal.background;
				
				if(lEyeStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(lEyeStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(rEye.Contains(Event.current.mousePosition))
			{
				GUI.Box (rEye, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "rEye";
				curInvSlotTexture = rEyeStyle.normal.background;
				
				if(rEyeStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(rEyeStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(neck.Contains(Event.current.mousePosition))
			{
				GUI.Box (neck, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "neck";
				curInvSlotTexture = neckStyle.normal.background;
				
				if(neckStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(neckStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(shirt.Contains(Event.current.mousePosition))
			{
				GUI.Box (shirt, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "shirt";
				curInvSlotTexture = shirtStyle.normal.background;
				
				if(shirtStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(shirtStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(vest.Contains(Event.current.mousePosition))
			{
				GUI.Box (vest, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "vest";
				curInvSlotTexture = vestStyle.normal.background;
				
				if(vestStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(vestStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(jacket.Contains(Event.current.mousePosition))
			{
				GUI.Box (jacket, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "jacket";
				curInvSlotTexture = jacketStyle.normal.background;
				
				if(jacketStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(jacketStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(lShoulder.Contains(Event.current.mousePosition))
			{
				GUI.Box (lShoulder, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "lShoulder";
				curInvSlotTexture = lShoulderStyle.normal.background;
				
				if(lShoulderStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(lShoulderStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(rShoulder.Contains(Event.current.mousePosition))
			{
				GUI.Box (rShoulder, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "rShoulder";
				curInvSlotTexture = rShoulderStyle.normal.background;
				
				if(rShoulderStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(rShoulderStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(lWrist.Contains(Event.current.mousePosition))
			{
				GUI.Box (lWrist, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "lWrist";
				curInvSlotTexture = lWristStyle.normal.background;
				
				if(lWristStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(lWristStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(rWrist.Contains(Event.current.mousePosition))
			{
				GUI.Box (rWrist, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "rWrist";
				curInvSlotTexture = rWristStyle.normal.background;
				
				if(rWristStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(rWristStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(lHand.Contains(Event.current.mousePosition))
			{
				GUI.Box (lHand, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "lHand";
				curInvSlotTexture = lHandStyle.normal.background;
				
				if(lHandStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(lHandStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(rHand.Contains(Event.current.mousePosition))
			{
				GUI.Box (rHand, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "rHand";
				curInvSlotTexture = rHandStyle.normal.background;
				
				if(rHandStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(rHandStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(belt.Contains(Event.current.mousePosition))
			{
				GUI.Box (belt, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "belt";
				curInvSlotTexture = beltStyle.normal.background;
				
				if(beltStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(beltStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(pouch1.Contains(Event.current.mousePosition))
			{
				GUI.Box (pouch1, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "pouch1";
				curInvSlotTexture = pouch1Style.normal.background;
				
				if(pouch1Style.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(pouch1Style.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(pouch2.Contains(Event.current.mousePosition))
			{
				GUI.Box (pouch2, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "pouch2";
				curInvSlotTexture = pouch2Style.normal.background;
				
				if(pouch2Style.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(pouch2Style.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(pouch3.Contains(Event.current.mousePosition))
			{
				GUI.Box (pouch3, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "pouch3";
				curInvSlotTexture = pouch3Style.normal.background;
				
				if(pouch3Style.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(pouch3Style.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(pouch4.Contains(Event.current.mousePosition))
			{
				GUI.Box (pouch4, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "pouch4";
				curInvSlotTexture = pouch4Style.normal.background;
				
				if(pouch4Style.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(pouch4Style.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(pouch5.Contains(Event.current.mousePosition))
			{
				GUI.Box (pouch5, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "pouch5";
				curInvSlotTexture = pouch5Style.normal.background;
				
				if(pouch5Style.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(pouch5Style.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(pants.Contains(Event.current.mousePosition))
			{
				GUI.Box (pants, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "pants";
				curInvSlotTexture = pantsStyle.normal.background;
				
				if(pantsStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(pantsStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(lLeg.Contains(Event.current.mousePosition))
			{
				GUI.Box (lLeg, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "lLeg";
				curInvSlotTexture = lLegStyle.normal.background;
				
				if(lLegStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(lLegStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(rLeg.Contains(Event.current.mousePosition))
			{
				GUI.Box (rLeg, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "rLeg";
				curInvSlotTexture = rLegStyle.normal.background;
				
				if(rLegStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(rLegStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(boots.Contains(Event.current.mousePosition))
			{
				GUI.Box (boots, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "boots";
				curInvSlotTexture = bootsStyle.normal.background;
				
				if(bootsStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(bootsStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(lFoot.Contains(Event.current.mousePosition))
			{
				GUI.Box (lFoot, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "lFoot";
				curInvSlotTexture = lFootStyle.normal.background;
				
				if(lFootStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(lFootStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		if(rFoot.Contains(Event.current.mousePosition))
			{
				GUI.Box (rFoot, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "rFoot";
				curInvSlotTexture = rFootStyle.normal.background;
				
				if(rFootStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(rFootStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		
		
		
	}
	
	void PouchSlots()
	{
		var xPos = Screen.width / 500;
		var yPos = Screen.height / 1.11f;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 500;
	
		DragDrop chs = (DragDrop)inventory.GetComponent("DragDrop");
		
		
		Rect pouch1hotbar = new Rect(xPos + (width + xspacing), yPos, width, height);
		Rect pouch2hotbar = new Rect(xPos + ((width + xspacing) * 2), yPos, width, height);
		Rect pouch3hotbar = new Rect(xPos + ((width + xspacing) * 3), yPos, width, height);
		Rect pouch4hotbar = new Rect(xPos + ((width + xspacing) * 4), yPos, width, height);
		Rect pouch5hotbar = new Rect(xPos + ((width + xspacing) * 5), yPos, width, height);
		
		if(pouch1Style.normal.background != emptyInv)	
			{
				
				GUI.Box (pouch1hotbar, "pouch1", pouch1hotbarStyle);
				pouch1status = true;
			}
		if(pouch1Style.normal.background == emptyInv)	
			{
				pouch1status = false;
			}
			
		if(pouch2Style.normal.background != emptyInv)
			{			
				
				GUI.Box (pouch2hotbar, "pouch2", pouch2hotbarStyle);
				pouch2status = true;
			}
		if(pouch3Style.normal.background != emptyInv)
			{
				
				GUI.Box (pouch3hotbar, "pouch3", pouch3hotbarStyle);
				pouch3status = true;
			}
		if(pouch4Style.normal.background != emptyInv)
			{
				
				GUI.Box (pouch4hotbar, "pouch4", pouch4hotbarStyle);
				pouch4status = true;
			}
		if(pouch5Style.normal.background != emptyInv)
			{	
				
				GUI.Box (pouch5hotbar, "pouch5", pouch5hotbarStyle);
				pouch5status = true;
			}
		
		if(pouch1hotbar.Contains(Event.current.mousePosition))
			{
				GUI.Box (pouch1hotbar, "", outlineTexture);
				invSlotCheck = 1;
				chs.slotCheck = invSlotCheck;
				curInvSlot = "pouch1hotbar";
				curInvSlotTexture = pouch1hotbarStyle.normal.background;
				
				if(pouch1hotbarStyle.normal.background != emptyInv)
				{
					invSlotStatus = false;
				}
				if(pouch1hotbarStyle.normal.background == emptyInv)
				{
					invSlotStatus = true;
				}
				chs.slotStatus = invSlotStatus;
			}
		
		
		if(pouch1status == false)
		{
			pouch1hotbarStyle.normal.background = emptyInv;
		}
		
	}
	
	
	
	
	
	
	void PocketSlots()
	{
		var xPos = Screen.width / 500;
		var yPos = Screen.height / 1.11f;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 500;
		
		Rect leftPockethotbar = new Rect(xPos + ((width + xspacing) * 10.5f), yPos, width, height);
		GUI.Box (leftPockethotbar, "leftpocket", leftPockethotbarStyle);
		Rect rightPockethotbar = new Rect(xPos + ((width + xspacing) * 11.5f), yPos, width, height);
		GUI.Box (rightPockethotbar, "rightpocket", rightPockethotbarStyle);
	}
	void VestSlots()
	{
		var xPos = Screen.width / 500;
		var yPos = Screen.height / 1.11f;
		var width = Screen.width / 24;
		var height = Screen.height/ 12;
		var xspacing = Screen.width / 500;
		
		
		Rect vest1hotbar = new Rect(xPos + ((width + xspacing) * 14), yPos, width, height);
		GUI.Box (vest1hotbar, "vest1", vest1hotbarStyle);
		Rect vest2hotbar = new Rect(xPos + ((width + xspacing) * 15), yPos, width, height);
		GUI.Box (vest2hotbar, "vest2", vest2hotbarStyle);
		Rect vest3hotbar = new Rect(xPos + ((width + xspacing) * 16), yPos, width, height);
		GUI.Box (vest3hotbar, "vest3", vest3hotbarStyle);
		Rect vest4hotbar = new Rect(xPos + ((width + xspacing) * 17), yPos, width, height);
		GUI.Box (vest4hotbar, "vest4", vest4hotbarStyle);
		Rect vest5hotbar = new Rect(xPos + ((width + xspacing) * 18), yPos, width, height);
		GUI.Box (vest5hotbar, "vest5", vest5hotbarStyle);
	}
	void EnhanceSelector()
	{
		
	}
	void ScienceSelector()
	{
		
	}
	void SocketSelector()
	{
		
	}
	
	
	void Background()
	{
		Rect inventoryBackground = new Rect(Screen.width / 1.8f, Screen.height / 4.5f, Screen.width / 2, Screen.height / 1.5f);
		GUI.Box (inventoryBackground, "", inventoryBackgroundStyle);
		Rect equipBackground = new Rect(0, Screen.height / 4.5f, Screen.width / 2.2f, Screen.height / 1.5f);
		GUI.Box (equipBackground, "", equipBackgroundStyle);
	}

}
