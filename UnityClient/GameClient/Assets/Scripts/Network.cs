using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class Network : MonoBehaviour
{
    static SocketIOComponent socket;

    //pt2
    public GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //pt1
        socket = GetComponent<SocketIOComponent>();
        socket.On("open",OnConnected);

        //pt2
        socket.On("spawn",OnSpawned);
    }


    //pt1
    void OnConnected(SocketIOEvent e){

        Debug.Log("connected");
        //socket.Emit("test");
        //socket.Emit("move");

    }

    //pt2
    void OnSpawned(SocketIOEvent e){

        Debug.Log("Spawned");
        Instantiate(playerPrefab);

    }


    
}
