using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {

    //public Columna game;
    //public Player player;

    private void Start()
    {
        //game = GetComponent<Columna>();
        //player = GetComponent<Player>();
    }

    public void FadeGame()
    {
        Invoke("PlayGame", .3f);

    }

    public void FadeMenu()
    {
        Invoke("PlayMenu", .3f);

    }

    public void FadeOptions()
    {
        Invoke("PlayOptions", .3f);

    }

    public void FadeAbout()
    {
        Invoke("PlayAbout", .3f);

    }

    public void FadeQuit()
    {
        Invoke("QuitGame", .2f);

    }
    public void FadeLoad1()
    {
        Invoke("LoadLevel1", .2f);
    }

    //---------------------------------------------------------------------

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void PlayMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PlayOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void PlayAbout()
    {
        SceneManager.LoadScene("About");
    }
    public void LoadLevel1() // nivel 1
    {
        SceneManager.LoadScene("Level1");
        //game.columVelocity = game.tempColumVelocity;
        //game.metros = 0;
        //game.currentTime = 0.0f;
        //player.isAlive = true;
        //player.isMeta = false;
        //player.imagePlayer.sprite.name = player.nameGeo[Random.Range(0, 4)];
        //player.SetGeometry();
    }


    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
