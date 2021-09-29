using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    public ParticleSystem pickupEffect;

    GameObject player;
    PlayerHealth playerHealth;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
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
        playerHealth.currentHealth += 35;
        playerHealth.healthSlider.value = playerHealth.currentHealth;
        playerHealth.isHealthUp = true;

        Destroy(gameObject);
    }
}
