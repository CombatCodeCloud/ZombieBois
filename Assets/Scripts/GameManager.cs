using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int playerHealth;
    public GameObject player;
    private void Update()
    {
        playerHealth = PlayerScript.playerHealth;
        if (playerHealth == 0)
        {
            player.SetActive(false);
            SceneManager.LoadScene("GameOver");
        }
    }

}
