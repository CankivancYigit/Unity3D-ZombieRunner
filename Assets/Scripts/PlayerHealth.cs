using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHitPoints = 100f;
    
    public void TakeDamage(float damage)
    {
        playerHitPoints -= damage;
        if (playerHitPoints <= 0f)
        {
            Debug.Log("I'm dead");
            GetComponent<DeathHandler>().HandleDeath();

            AudioSource[] allSounds = FindObjectsOfType<AudioSource>();
            for (int i = 0; i < allSounds.Length; i++)
            {
                allSounds[i].enabled = false;
            }
        }
    }
}
