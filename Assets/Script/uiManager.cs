using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class uiManager : MonoBehaviour
{
    public GameObject popupInfo;


    public void PlayMe()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void InfoIn()
    {
        popupInfo.SetActive(true);
    }

    public void InfoOut()
    {
        popupInfo.SetActive(false);
    }

    public void Single()
    {
        SceneManager.LoadScene(2);
    }

    public void Dual()
    {
        SceneManager.LoadScene(4);
    }
}
