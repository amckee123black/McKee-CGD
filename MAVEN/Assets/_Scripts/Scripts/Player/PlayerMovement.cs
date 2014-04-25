using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
    public float speed = 6.0F;
	public float runSpeed = 10.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 80.0F;
	public float rotationSpeed = 60.0F;
    private Vector3 moveDirection = Vector3.zero;
    void Update() {
		
		transform.Rotate (0, Input.GetAxis("Rotate") * rotationSpeed * Time.deltaTime, 0);
		
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded) {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
			//makes the character jump
            if (Input.GetButton("Jump"))
			{
                moveDirection.y = jumpSpeed;
			}
			//makes the character run
			if (Input.GetKey (KeyCode.LeftShift))
			{
				Run();
			}
	    }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
	
	private void Run()
	{
		PlayerVitals pv = (PlayerVitals)GetComponent("PlayerVitals");
		
		
		if(pv.curStamina > 0)
		{	
			moveDirection *= runSpeed;
		}
		if(Input.GetButton ("Jump"))
		{
			moveDirection.y = jumpSpeed;
		}
	}
}