using UnityEngine;

public class GunGraphics : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AudioSource gunsound = GetComponent<AudioSource>();
            gunsound.Play();
            GetComponent<Animation>().Play("GunShot");
        }
    }
}

