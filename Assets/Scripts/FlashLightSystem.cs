using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSystem : MonoBehaviour
{
    [SerializeField] float angleDecay = 0.5f;
    [SerializeField] float minSpotAngle = 40f;

    [SerializeField] float intensityDecay = 0.1f;
    Light myLight;

    private void Start()
    {
        myLight = GetComponent<Light>();
    }

    private void Update()
    {
        DecreaseSpotAngle();
        DecreaseIntensity();
    }

    public void RestoreSpotAngle(float spotAngle)
    {
        myLight.spotAngle = spotAngle;
    }

    public void RestoreIntensity(float intensity)
    {
        myLight.intensity = intensity;
    }

    void DecreaseSpotAngle()
    {
        if (myLight.spotAngle <= minSpotAngle)
        {
            return;
        }
        else
        {
            myLight.spotAngle -= angleDecay * Time.deltaTime;
        }    
    }

    void DecreaseIntensity()
    {
        myLight.intensity -= intensityDecay * Time.deltaTime;
    }
}
