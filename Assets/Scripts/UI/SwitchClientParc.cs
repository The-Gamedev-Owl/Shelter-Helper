using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchClientParc : MonoBehaviour
{
    [SerializeField] private GameObject _client;
    [SerializeField] private GameObject _parc;


    public void Switch()
    {
        _client.SetActive(!_client.activeSelf);
        _parc.SetActive(!_parc.activeSelf);
    }
}
