using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPlay : MonoBehaviour {
	public static int damageAmount;
	public float targetDistance;
	public float allowedRange;
	public string gunType;
	public float playerSpeed;
	public float nextFire, firerate;


	// Update is called once per frame
	void Update () 
	{
		gunType = PickUpGun.gunName;
		switch(gunType)
		{
		case "FiveSeven":
			damageAmount = 27;
			allowedRange = 15;
			firerate = 0.2f;
			break;

		case "Model70":
			damageAmount = 90;
			allowedRange = 50;
			firerate = 1f;
			break;

		default:
			damageAmount = 5;
			allowedRange = 2;
			firerate = 0f;
			break;
		}
		if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + firerate;
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
