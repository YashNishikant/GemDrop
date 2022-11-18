using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.transform.tag.Equals("Gem"))
            Destroy(transform.GetComponent<Rigidbody>());
    }

}
