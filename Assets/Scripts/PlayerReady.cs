using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReady : MonoBehaviour
{
    public static bool gunActive;
    public GameObject gunObj;

    // Update is called once per frame
    void Update()
    {

        gunActive = PickUpGun.gunActive;
        if(gunActive)
        {
            gunObj.SetActive(false);
            EnemyScript.navReady = true;
            Destroy(gameObject);
        }
    }
}
