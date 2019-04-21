using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;

    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnClick(Vector3 position)
    {
        var navPos = player.GetComponent<NavigatePosition>();

        var netMove = player.GetComponent<NetworkMove>();


        navPos.Navigate(position);


        netMove.OnMove(position);
    }
}
