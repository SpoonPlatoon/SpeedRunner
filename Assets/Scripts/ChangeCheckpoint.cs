using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCheckpoint : MonoBehaviour
{
    public GameObject checkpoint;
    public CheckPoint chekPoint;
    public Transform checkPointPosition;
    public KillZone killZone;


    private void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            chekPoint.curCheckPoint = checkPointPosition;
            killZone.spawnpoint = checkPointPosition;
            gameObject.SetActive(false);
        }
    }
}
