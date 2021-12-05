using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHider : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelSelect;

    public void LevelSelect()
    {
        mainMenu.SetActive(false);
    }
}
