using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionStay(Collision other)
    {
        Debug.Log("El Player esta colicionado con: "+ other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("El Player esta colicionado con: " + other.gameObject.name);
    }
}
