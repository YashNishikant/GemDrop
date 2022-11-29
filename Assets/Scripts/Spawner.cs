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
    private float f;
    [SerializeField] private float interval;
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
                GameObject g = Instantiate(gemList[Random.Range(0,gemList.Count-1)], new Vector3(Random.Range(-40, 40), 20, Random.Range(1, 20)), Quaternion.identity);
                f = 20 + g.transform.position.z / 2;
                limitValueX(g.transform, f);

                spawn = false;
            }
        }

        if ((int)time != timechanged)
        {
            spawn = true;
        }

    }

    void limitValueX(Transform g, float val)
    {
        if (g.position.x < -val)
        {
            g.position = new Vector3(-val, g.position.y, g.position.z);
        }
        if (g.position.x > val)
        {
            g.position = new Vector3(val, g.position.y, g.position.z);
        }

    }

}