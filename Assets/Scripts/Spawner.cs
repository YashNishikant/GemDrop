using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{

    private float time;
    private float timechanged;
    private bool spawn;
    [SerializeField] private float interval;
    [SerializeField] private ParticleSystem trail;
    [SerializeField] private List<GameObject> gemList;
    [SerializeField] private List<Material> skyboxList;

    private void Start()
    {
        RenderSettings.skybox = skyboxList[Random.Range(0, skyboxList.Count - 1)];
        spawn = true;
    }

    void Update()
    {
        time += Time.deltaTime;

        if ((int)time % interval == 0) {
            if (spawn) {
                time = timechanged;
                GameObject g = Instantiate(gemList[Random.Range(0,gemList.Count-1)], new Vector3(Random.Range(-10, 10), 20, Random.Range(-10, 10)), Quaternion.identity);
                ParticleSystem p = Instantiate(trail, g.transform.position + new Vector3(0, 0.5f, 0), Quaternion.identity);

                spawn = false;
            }
        }

        if ((int)time != timechanged)
        {
            spawn = true;
        }

    }

}
