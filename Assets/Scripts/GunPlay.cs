using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPlay : MonoBehaviour {
	public static int damageAmount;
	public float targetDistance;
	public float allowedRange;

	public string gunType;

	public float playerSpeed;

	float nextFire, firerate;

	float reloadTime;
	public float reload;
	public bool reloading;
	public static int clipSize, timesFired;

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
			clipSize = 10;
			reloadTime = 2.2f;

			if (timesFired == clipSize)
			{
				reloading = true ;
				timesFired = 0;

			}
			break;


		case "Model70":
			damageAmount = 90;
			allowedRange = 50;
			firerate = 1f;
			clipSize = 5;
			reloadTime = 3.7f;
			if (timesFired == clipSize)
			{
				reloading = true;
				timesFired = 0;
			}



			break;

		default:
			damageAmount = 5;
			allowedRange = 2;
			firerate = 0f;
			break;
		}




		if (Input.GetButtonDown("Reload"))
        {
			timesFired = clipSize;
        }

		if (Input.GetButtonDown("Fire1") && Time.time > nextFire && !reloading)
		{
			reload = Time.time + reloadTime;
			nextFire = Time.time + firerate;
			Fire();
		}
		if (Input.GetButtonDown("Fire1") && Time.time > nextFire && reloading)
		{
			Reload();
        }

	}

	void Fire ()
    {
		timesFired =+ (timesFired + 1);

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
	void Reload()
	{
		Debug.Log("Reloading!!!");
		nextFire = Time.time + firerate;
		if (Time.time > reload)
		{
			reloading = false;
		}

	}

}


