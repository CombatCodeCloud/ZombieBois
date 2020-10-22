using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerScript : MonoBehaviour
{
    public static int playerHealth = 100;
    private void OnTriggerEnter(Collider EnemyCol)
    {
        if (EnemyCol.gameObject.tag == "Enemy")
        {
            //work here
            Debug.Log("ayo the DAMAGE here");
            playerHealth -= 10;
        }
    }
}
