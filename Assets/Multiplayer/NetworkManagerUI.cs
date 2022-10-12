using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class NetworkManagerUI : MonoBehaviour
{

    [SerializeField] private Button button_server;
    [SerializeField] private Button button_host;
    [SerializeField] private Button button_client;

    private void Awake() {
        button_server.onClick.AddListener(() => {
            NetworkManager.Singleton.StartServer();
        }); // Button listener for Server
        button_host.onClick.AddListener(() => {
            NetworkManager.Singleton.StartHost();
        }); // Button listener for Host
        button_client.onClick.AddListener(() => {
            NetworkManager.Singleton.StartClient();
        }); // Button listener for Client
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
