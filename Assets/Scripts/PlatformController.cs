using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlatformController : MonoBehaviour
{

    [SerializeField] private float speed;

    float f = 20;

    void Update()
    {

        if (Input.GetKey(KeyCode.W)) 
        {
            transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)){
            transform.position += new Vector3(0, 0, -speed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }

        f = 20+transform.position.z/2;
        limitValueX(f);
        limitValueZ(20f);
        
    }

    void limitValueX(float val)
    {
        if (transform.position.x < -val)
        {
            transform.position = new Vector3(-val, transform.position.y, transform.position.z);
        }
        if (transform.position.x > val)
        {
            transform.position = new Vector3(val, transform.position.y, transform.position.z);
        }

    }

    void limitValueZ(float val) {

        if (transform.position.z < 1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 1);
        }
        if (transform.position.z > val)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, val);
        }
    }

}
