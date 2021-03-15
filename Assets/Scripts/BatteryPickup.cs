using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float spotAngle = 70f;
    [SerializeField] float intensity = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponentInChildren<FlashLightSystem>().RestoreSpotAngle(spotAngle);
            other.gameObject.GetComponentInChildren<FlashLightSystem>().RestoreIntensity(intensity);
            Destroy(gameObject);
        }
    }
}
