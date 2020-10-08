using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchClientParc : MonoBehaviour
{
    [SerializeField] private GameObject _client;
    [SerializeField] private GameObject _clientBG;
    [SerializeField] private GameObject _parc;
    [SerializeField] private GameObject _parcBG;


    public void Switch()
    {
        _client.SetActive(!_client.activeSelf);
        _clientBG.SetActive(!_clientBG.activeSelf);
        _parc.SetActive(!_parc.activeSelf);
        _parcBG.SetActive(!_parcBG.activeSelf);
    }
}
