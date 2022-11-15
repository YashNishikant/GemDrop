using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private float score;
    private Text scoretext;
    private Text gameQuit;

    void Start()
    {
        scoretext = transform.GetChild(0).GetComponent<Text>();
        gameQuit = transform.GetChild(1).GetComponent<Text>();
    }

    void Update()
    {
        scoretext.text = "Score: " + score;
        if (score >= 10)
        {
            gameQuit.text = "PRESS SPACE TO QUIT";
            if (Input.GetKeyDown(KeyCode.Space)) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
        else {
            gameQuit.text = "";
        }
    }

    public void incrementScore()
    {
        score++;
    }

}
