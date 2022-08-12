using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCollisions : MonoBehaviour
{
    private bool change = false;

    public float cooldown = 1f;
    private void OnTriggerExit(Collider other)
    {
        if(cooldown <= 0 && other.gameObject.CompareTag("Playerr") && change == false)
        {
            other.transform.localScale = transform.localScale / 2;
            change = true;
            cooldown = 1;
        }
        if (cooldown <= 0 && other.gameObject.CompareTag("Playerr") && change == true)
        {
            other.transform.localScale = transform.localScale * 1;
            change = false;
            cooldown = 1;
        }
    }

    private void Update()
    {
        if(cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
    }

}
