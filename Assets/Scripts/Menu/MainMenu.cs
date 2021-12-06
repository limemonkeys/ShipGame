using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject characterSelect;

    public void PlayGame(string character)
    {
        PlayerSelectController.player = character;
        SceneManager.LoadScene("WaterSim");
    }

    public void SelectCharacter() 
    {
        mainMenu.SetActive(false);
        characterSelect.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
