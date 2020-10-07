using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongPause : MonoBehaviour
{
    void Start()
    {
        SongScripts.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }

}
