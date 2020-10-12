var gunType : String;
var gunsound : AudioSource = GetComponent.<AudioSource>();
gunType = PickUpGun.gunName;
function Update() {
if(Input.GetButtonDown("Fire1")) {
switch (gunType){

	case "FiveSeven":

	gunsound.Play();
	GetComponent.<Animation>().Play("FiveSevenAnim");
	break;

	default:
	break;
		}
	}
}