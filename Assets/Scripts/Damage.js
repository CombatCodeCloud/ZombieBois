var damageAmount : int;
var targetDistance : float;
var allowedRange : float;
var gunType : String;
function Update () {
gunType = PickUpGun.gunName;
	switch(gunType)
	{
		case "FiveSeven":
		damageAmount = 5;
		allowedRange = 15;
		break;

		default:
		damageAmount = 2;
		allowedRange = 2;
		break;
	}

if (Input.GetButtonDown("Fire1")) {
var Shot : RaycastHit; 
	if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), Shot)) {
		targetDistance = Shot.distance;
		if (targetDistance < allowedRange) {
			Shot.transform.SendMessage("DeductPoints", damageAmount, SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
