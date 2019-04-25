using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public static UIManager instance;

    public GameObject zigzagPanel;
    public GameObject gameOverpanel;
    public GameObject taptext;
    public Text score;
    public Text highscore1;
    public Text highscore2;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {
        highscore1.text = "High Score: " + PlayerPrefs.GetInt("highscore").ToString();

    }

    public void GameStart()
    {
        
        taptext.SetActive(false);
        zigzagPanel.GetComponent<Animator>().Play("zigzagPanel");
    }

    public void GameOver()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        highscore2.text = PlayerPrefs.GetInt("highscore").ToString();
        gameOverpanel.SetActive(true);
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
