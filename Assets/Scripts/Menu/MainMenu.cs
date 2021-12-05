using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelSelect;

    public void PlayGame()
    {
        SceneManager.LoadScene("WaterSim");
    }

    public void LevelSelect()
    {
        mainMenu.SetActive(false);
        levelSelect.SetActive(true);
    }

    public void SelectFour() 
    {
        SceneManager.LoadScene("LevelFour");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
