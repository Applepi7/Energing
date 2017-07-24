using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    public GameObject HelpUI;
    public GameObject FirstHelp;
    public GameObject SecondHelp;
    public GameObject ThirdHelp;
    public GameObject PauseUI;
    public GameObject Mainmenu;
    public GameObject Restart;
    

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ShowHowTo()
    {
        HelpUI.SetActive(true);
    }

    public void ShowPause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void ExitHowTo()
    {
        HelpUI.SetActive(false);
    }

    public void ExitPause()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void ShowFirst()
    {
        FirstHelp.SetActive(true);
        SecondHelp.SetActive(false);
        ThirdHelp.SetActive(false);

        Page.instance.pageNum = 1;
    }

    public void ShowSecond()
    {
        FirstHelp.SetActive(false);
        SecondHelp.SetActive(true);
        ThirdHelp.SetActive(false);

        Page.instance.pageNum = 2;
    }

    public void ShowThird()
    {
        FirstHelp.SetActive(false);
        SecondHelp.SetActive(false);
        ThirdHelp.SetActive(true);

        Page.instance.pageNum = 3;
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("MainmenuScene");
    }

    public void RestartScene()
    {
        SceneManager.LoadScene("Game");
    }

}
