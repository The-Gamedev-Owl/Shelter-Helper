using System.Collections;
using System.Collections.Generic;
using System.Runtime.Hosting;
using UnityEngine;

public class GameScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit(); // Quits the game
        }
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
