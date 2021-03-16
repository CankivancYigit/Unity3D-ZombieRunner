using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas damageDisplay;
    [SerializeField] float damageDisplayingTime = 0.3f;
   
    void Start()
    {
        damageDisplay.enabled = false;
    }

    public void ShowDamage()
    {
        StartCoroutine(ShowSplatter());
    }

    IEnumerator ShowSplatter()
    {
        damageDisplay.enabled = true;
        yield return new WaitForSeconds(damageDisplayingTime);
        damageDisplay.enabled = false;
    }
}
