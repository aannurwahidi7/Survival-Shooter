using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSound : MonoBehaviour
{
    PlayerMovement playerMovement;
    PlayerHealth playerHealth;
    GameObject player;

    public AudioSource speedUp;
    public AudioSource healthUp;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.isSpeedUp == true)
        {
            speedUp.Play();
        }

        else if (playerHealth.isHealthUp == true)
        {
            healthUp.Play();
            playerHealth.isHealthUp = false;
        }
    }
}
