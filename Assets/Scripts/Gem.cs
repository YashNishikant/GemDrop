using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{

    [SerializeField] private ParticleSystem impact;
    [SerializeField] private ParticleSystem spawn;

    void Start()
    {
        Instantiate(spawn, transform.position, Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag.Equals("Platform")) {
            impact.GetComponent<ParticleSystemRenderer>().material = transform.GetComponent<MeshRenderer>().material;
            Instantiate(impact, collision.GetContact(0).point, Quaternion.identity);
            FindObjectOfType<Spawner>().incrementScore();
            Destroy(this.gameObject);
        }
    }

}
