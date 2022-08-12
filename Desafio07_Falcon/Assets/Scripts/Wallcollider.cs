using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallcollider : MonoBehaviour
{
    public float cooldown = 2f;
    public float time = 0;
    private Transform newposition;


    private void OnCollisionEnter(Collision collision)
    {
        time = 0;
    }
    private void OnCollisionStay(Collision other)
    {
        time += Time.deltaTime;
        if (time >= cooldown)
        {
            //newposition = new Vector3(Random.Range(-4.0f, 4.0f), 0, Random.Range(-4.0f, 4.0f));
            other.transform.position = new Vector3(Random.Range(-4.0f, 4.0f), 2, Random.Range(-4.0f, 4.0f));
        }
    }

}
