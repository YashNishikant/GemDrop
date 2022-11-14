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
    private float score;
    [SerializeField] float interval;
    [SerializeField] private Text t;
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
                Instantiate(gemList[Random.Range(0,gemList.Count-1)], new Vector3(Random.Range(-10, 10), 20, Random.Range(-10, 10)), Quaternion.identity);
                spawn = false;
            }
        }

        if ((int)time != timechanged) {
            spawn = true;
        }

        t.text = "Score: " + score;

    }

    public void incrementScore() {
        score++;
    }

}
