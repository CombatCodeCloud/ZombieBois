using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {
	public static int damageAmount;
	public float targetDistance;
	public float allowedRange;
	string gunType;
	float playerSpeed;

	// Update is called once per frame
	void Update () 
	{
		gunType = PickUpGun.gunName;
		switch(gunType)
		{
		case "FiveSeven":
			damageAmount = 27;
			allowedRange = 15;
			break;

		case "Model70":
			damageAmount = 90;
			allowedRange = 50;
			break;

		default:
			damageAmount = 5;
			allowedRange = 2;
			break;
		}
		if (Input.GetButtonDown("Fire1"))
		{
			RaycastHit Shot;
			if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
			{
				targetDistance = Shot.distance;
				if (targetDistance < allowedRange)
				{
					Shot.transform.SendMessage("DeductPoints", damageAmount, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}

}
