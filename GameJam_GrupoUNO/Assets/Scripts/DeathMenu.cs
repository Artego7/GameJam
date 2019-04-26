using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {
    public Player player;
    public GameObject deathMenuUI;
    public Columna game;
    public Text textDistance;
    void Start()
    {
        deathMenuUI.SetActive(false);
    }
    // Update is called once per frame
    void Update ()
    {
        textDistance.text = game.metros.ToString();
        if (!player.isAlive)
        {
            Invoke("Pause", player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + player.delay);
        }
        else
        {
            Resume();
        }
	}
    void Resume()
    {
        deathMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        deathMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
