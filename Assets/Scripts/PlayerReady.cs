using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReady : MonoBehaviour
{
    public static bool gunActive;
    public GameObject gunText;

    // Update is called once per frame
    void Update()
    {

        gunActive = PickUpGun.gunActive;
        if(gunActive)
        {
            gunText.SetActive(false);
            Destroy(gameObject);
        }
    }
}
