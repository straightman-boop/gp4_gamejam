using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public GameObject optionsUI;

    public void loadSceneFunction(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void quitFunction()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void openOptions()
    {
       optionsUI.SetActive(true);
    }
    public void closeOptions()
    {
        optionsUI.SetActive(false);
    }

}