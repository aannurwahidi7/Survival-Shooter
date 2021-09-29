using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public ParticleSystem pickupEffect;

    GameObject player;
    PlayerMovement playerMovement;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.GetType() == typeof(CapsuleCollider))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        pickupEffect.Play();
        playerMovement.isSpeedUp = true;        

        Destroy(gameObject);
    }
}
