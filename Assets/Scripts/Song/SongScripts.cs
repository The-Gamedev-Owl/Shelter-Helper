using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongScripts : MonoBehaviour
{
    private static SongScripts instance = null;
    public static SongScripts Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);

    }
}
