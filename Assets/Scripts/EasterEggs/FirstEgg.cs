using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FirstEgg : MonoBehaviour
{
    float theDistance = PlayerCasting.distanceFromTarget;
    public GameObject eggText;

    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 6)
        {
            eggText.SetActive(true);
        }
        else
        {
            eggText.SetActive(false);
        }
    }
    void OnMouseExit()
    {
        eggText.SetActive(false);
    }
}
