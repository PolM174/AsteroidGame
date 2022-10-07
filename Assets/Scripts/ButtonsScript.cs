using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo...");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }


    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
