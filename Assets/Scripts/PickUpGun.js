var theDistance : float = PlayerCasting.distanceFromTarget;

var pickupText : GameObject;
var fakeGun : GameObject;
var realGun : GameObject;
static var gunName : String;

function Update() {
	theDistance = PlayerCasting.distanceFromTarget;
}

function OnMouseOver() { 
if (theDistance <= 4) {
pickupText.SetActive(true);
}
if (Input.GetButtonDown("Interact")) {
		if (theDistance <= 2) {
			TakeGun();
		}
	}
}

function OnMouseExit() { 
	pickupText.SetActive(false);

}

function TakeGun() { 
	transform.position = Vector3(0, -1000, 0);
	pickupText.SetActive(false);
	fakeGun.SetActive(false);
	realGun.SetActive(true);
	gunName = realGun.name;
	Debug.Log(gunName);
}