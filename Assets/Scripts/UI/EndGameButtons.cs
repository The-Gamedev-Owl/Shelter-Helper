using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameButtons : MonoBehaviour
{
    public void OpenURL(string url)
    {
        Application.OpenURL(url);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
