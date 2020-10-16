using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpGun : MonoBehaviour {
	float theDistance = PlayerCasting.distanceFromTarget;

	public GameObject pickupText;
	public GameObject fakeGun;
	public GameObject realGun;
	public static GameObject currentGun;
	public static bool gunActive;
	public static string gunName;

	// Update is called once per frame
	void Update ()
	{
		theDistance = PlayerCasting.distanceFromTarget;

	}
	void OnMouseOver() { 
		if (theDistance <= 3) {
			pickupText.SetActive(true);
		}
		else
        {
			pickupText.SetActive(false);
        }

		if (Input.GetButtonDown("Interact")) {
			if (theDistance <= 2) {
				TakeGun();
			}
		}
	}

	void OnMouseExit() { 
		pickupText.SetActive(false);
	}

	void TakeGun() {
		if (gunActive)
		{
			currentGun.SetActive(false);
			GunPlay.timesFired = 0;

		}
		transform.position = new Vector3(0, -1000, 0);
		pickupText.SetActive(false);
		fakeGun.SetActive(false);
		realGun.SetActive(true);
		gunActive = true;
		currentGun = realGun;

		gunName = realGun.name;
		Debug.Log(gunName);
	}
}
