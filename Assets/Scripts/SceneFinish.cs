using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneFinish : MonoBehaviour
{
    [SerializeField] Canvas finishSceneCanvas;
    void Start()
    {
        finishSceneCanvas.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        finishSceneCanvas.enabled = true;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Destroy(gameObject);

        AudioSource[] allSounds = FindObjectsOfType<AudioSource>();
        for (int i = 0; i < allSounds.Length; i++)
        {
            allSounds[i].enabled = false;
        }
    }
}
