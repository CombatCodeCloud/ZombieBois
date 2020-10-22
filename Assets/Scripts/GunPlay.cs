using UnityEngine;

public class GunPlay : MonoBehaviour
{
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
    void Update()
    {
        gunType = PickUpGun.gunName;
        switch (gunType)
        {
            case "FiveSeven":
                damageAmount = 30;
                allowedRange = 20;
                firerate = 0.2f;
                clipSize = 10;
                reloadTime = 2.2f;
                break;


            case "ScoutG08":
                damageAmount = 70;
                allowedRange = 50;
                firerate = 1f;
                clipSize = 10;
                reloadTime = 3.7f;
                break;

            case "M2Dual":
                damageAmount = 100;
                allowedRange = 5;
                firerate = 0.1f;
                clipSize = 2;
                reloadTime = 1.1f;
                break;

            default:
                damageAmount = 10;
                allowedRange = 2;
                firerate = 0f;
                break;
        }

        if(PickUpGun.gunActive)
        {
            ReloadingCheck();
        }

        void ReloadingCheck()
        {
            if (timesFired == clipSize)
            {
                reloading = true;
                timesFired = 0;
            }
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

    void Fire()
    {
        timesFired = +(timesFired + 1);

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


