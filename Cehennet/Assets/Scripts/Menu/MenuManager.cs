using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject HowToPlay;
    public GameObject ayarlar;
    public GameObject hakkinda;


    public void Oyna()
    {
        
        SceneManager.LoadScene(1);
    }
    public void Ayarlar()
    {
        ayarlar.SetActive(true);
    }
    public void nasilOyanir()
    { 
        HowToPlay.SetActive(true);
    }

    public void hakkind()
    {
        hakkinda.SetActive(true);
    }

    public void Quit()
    {
        
        Application.Quit();
    }
    public void Closeh()
    {
        
        HowToPlay?.SetActive(false);
    }
    public void Closea()
    {

        ayarlar.SetActive(false);
    }
    public void Closeha()
    {

        hakkinda.SetActive(false);
    }

    public void fullscene(bool isfullScene)
    {
        Screen.fullScreen = isfullScene;
    }
}
