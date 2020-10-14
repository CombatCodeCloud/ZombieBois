using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpGun : MonoBehaviour {
	float theDistance = PlayerCasting.distanceFromTarget;

	public GameObject pickupText;
	public GameObject fakeGun;
	 public GameObject realGun;
	static bool gunActive;
	public static string gunName;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		theDistance = PlayerCasting.distanceFromTarget;

	}
	void OnMouseOver() { 
		if (theDistance <= 4) {
			pickupText.SetActive(true);
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
		if(gunActive)
		{
			Debug.Log("work here");
		}
		transform.position = new Vector3(0, -1000, 0);
		pickupText.SetActive(false);
		fakeGun.SetActive(false);
		realGun.SetActive(true);
		gunActive = true;
		gunName = realGun.name;
		Debug.Log(gunName);
	}
}
