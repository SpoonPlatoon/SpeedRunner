using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Transform curCheckPoint;
    GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnTriggerEnter(Collider plyr)
    {
        if(plyr.gameObject.tag == "Player")
        {
            player.transform.position = curCheckPoint.position;
            player.transform.rotation = curCheckPoint.rotation;
        }
    }
}
