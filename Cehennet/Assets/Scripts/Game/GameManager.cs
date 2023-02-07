using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool hangibolge;

    PlayerSeytan playerSeytan;
    PlayerMelek playerMelek;
    spawnerMelek spawnerMelek;
    spawnerSeytan spawnerSeytan;
    yerMelek yerMelek;

    public GameObject melekplayer;
    public GameObject seytanplayer;
    public GameObject spawnerseytan;
    public GameObject spawnermelek;
    public GameObject yermelek;

    public int healt;
    public int maxhealt = 3;

    public GameObject[] hearts;

    public bool isscoring = true;
    public TMP_Text scoreTxT;
    public TMP_Text DeadscoreTxT;
    public int score;

    public GameObject PauseMenu;
    public GameObject DeadMenu;
    bool ispause;


    TMP_Text zamantxt;

    [SerializeField] private float time;


    Animator anim;

    private void Start()
    {
        hangibolge = true;
        playerSeytan = seytanplayer.GetComponent<PlayerSeytan>();
        playerMelek = melekplayer.GetComponent<PlayerMelek>();
        spawnerMelek = spawnermelek.GetComponent<spawnerMelek>();
        spawnerSeytan = spawnerseytan.GetComponent<spawnerSeytan>();
        yerMelek = yermelek.GetComponent<yerMelek>();
        anim=GetComponent<Animator>();
    }
    

    private void Update()
    {
        SetTime();

        if (isscoring)
        {
            score++;
            scoreTxT.text = score.ToString();
        }

        if (hangibolge == true)
        {
            spawnerMelek.enabled = true;
            playerMelek.enabled = true;
            yerMelek.enabled=true;
            playerSeytan.enabled = false;
            spawnerSeytan.enabled = false;
        }
        else
        {
            spawnerMelek.enabled = false;
            spawnerseytan.SetActive(true);
            playerMelek.enabled = false;
            yerMelek.enabled = false;
            playerSeytan.enabled = true;
            spawnerSeytan.enabled = true;
        }

        if (PlayerSeytan.isdead == true)
        {
            healt--;
            PlayerSeytan.isdead = false;
            healtSytem();
        }

         if (Input.GetKeyDown(KeyCode.Escape))
         {
             ispause = !ispause;
         }

         if (ispause)
         {
             PauseMenu.SetActive(true);
             Time.timeScale = 0f;
             isscoring = false;
         }
         else
         {
             PauseMenu.SetActive(false);
             Time.timeScale = 1f;
             isscoring = true;
         }

        if (healt <= 0)
        {
            isscoring = false;
            DeadscoreTxT.text = score.ToString();
            DeadMenu.SetActive(true);
            playerMelek.enabled = false;
            playerSeytan.enabled = false;
            spawnerSeytan.enabled = false;
            spawnerMelek.enabled = false;
        }

    }


    public static int SetTimeindex;
    private void SetTime()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            hangibolge = !hangibolge;
            time = 10;
            print("yer deðiþti");
            SetTimeindex = SetTimeindex + 1;
            PlayerMelek.anim.SetBool("run", false);
            PlayerSeytan.anim.SetBool("run", false);
        }
    }

    void healtSytem()
    {
        for (int i = 0; i < maxhealt; i++)
        {
            hearts[i].SetActive(false);
        }
        for (int i = 0; i < healt; i++)
        {
            hearts[i].SetActive(true);
        }
    }

    public void Menu() 
    {
        SceneManager.LoadScene(0);
    }
    public void Settings() 
    {
        SceneManager.LoadScene(2);
    }
    public void HowToPlaying() 
    {
        SceneManager.LoadScene(3);
    }
    public void TryAgain()
    {
        SceneManager.LoadScene(1);
    }
}
